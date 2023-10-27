using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrestructure.Cloud_Services.Interfaces
{
    public interface IFileStorageService
    {
        void Upload(byte[] bytes, string fileName);
    }
}
