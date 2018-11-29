using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Core.Upload
{
    public class FileService
    {
        private readonly FileRepository _fileRepository;

        public FileService(FileRepository fileRepository)
        {
            _fileRepository = fileRepository;
        }

        public async Task UploadAsync(params string[] filePaths)
        {
            foreach (var file in filePaths)
            {
                await _fileRepository.UploadDocumentAsync(file);
            }
        }
    }
}
