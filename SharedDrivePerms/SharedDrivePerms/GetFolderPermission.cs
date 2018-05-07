
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace SharedDrivePerms
{


    internal class GetFolderPermission
    {


        public String path { get; set; }
        
        public GetFolderPermission(string _path)
        {
            this.path = _path;
        }

                
        List<PermissionsModel> userPermission = new List<PermissionsModel>();
        
        public async Task<List<PermissionsModel>> GetPermissionAsync()
        {

            try
            {

                DirectoryInfo dInfo = new DirectoryInfo(path);
                DirectorySecurity dSecurity = dInfo.GetAccessControl();
                AuthorizationRuleCollection acl = await Task.Run(() => dSecurity.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount)));
                foreach (FileSystemAccessRule ace in acl)
                {
                    PermissionsModel Permodel = new PermissionsModel();
                    Permodel.IdentityReference = ace.IdentityReference.Value;
                    Permodel.AccessControlType = ace.AccessControlType.ToString();
                    Permodel.FileSystemRights = FileSystemRightsCorrector(ace.FileSystemRights, false).ToString();
                    Permodel.IsInherited = ace.IsInherited;
                    userPermission.Add(Permodel);

                }

            }

            catch (Exception ex)
            {
                throw ex;
                
            }

            return userPermission;

        }


        public FileSystemRights FileSystemRightsCorrector(FileSystemRights fsRights, bool removeSynchronizePermission = false)
        {

            const int C_BitGenericRead = (1 << 31);
            const int C_BitGenericWrite = (1 << 30);
            const int C_BitGenericExecute = (1 << 29);
            const int C_BitGenericAll = (1 << 28);

            const FileSystemRights C_FsrGenericRead = FileSystemRights.ReadAttributes | FileSystemRights.ReadData | FileSystemRights.ReadExtendedAttributes | FileSystemRights.ReadPermissions | FileSystemRights.Synchronize;
            const FileSystemRights C_FsrGenericWrite = FileSystemRights.AppendData | FileSystemRights.WriteAttributes | FileSystemRights.WriteData | FileSystemRights.WriteExtendedAttributes | FileSystemRights.ReadPermissions | FileSystemRights.Synchronize;
            const FileSystemRights C_FsrGenericExecute = FileSystemRights.ExecuteFile | FileSystemRights.ReadAttributes | FileSystemRights.ReadPermissions | FileSystemRights.Synchronize;

            if (((int)fsRights & C_BitGenericRead) != 0)
            {
                fsRights |= C_FsrGenericRead;
            }

            if (((int)fsRights & C_BitGenericWrite) != 0)
            {
                fsRights |= C_FsrGenericWrite;
            }

            if (((int)fsRights & C_BitGenericExecute) != 0)
            {
                fsRights |= C_FsrGenericExecute;
            }

            if (((int)fsRights & C_BitGenericAll) != 0)
            {
                fsRights |= FileSystemRights.FullControl;
            }

            fsRights = (FileSystemRights)((int)fsRights & ~(C_BitGenericRead | C_BitGenericWrite | C_BitGenericExecute | C_BitGenericAll));


            if (removeSynchronizePermission == true)
            {
                fsRights = (FileSystemRights)((int)fsRights & ~((int)FileSystemRights.Synchronize));
            }

            return fsRights;
        }


    }
}
