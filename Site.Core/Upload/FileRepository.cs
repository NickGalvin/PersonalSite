using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
using PersonalSite.Server;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Site.Core.Upload
{
    public class FileRepository
    {
        private IAmazonS3 _s3Client;
        private readonly SiteConfig _config;

        public FileRepository(SiteConfig config, IAmazonS3 s3Client)
        {
            _config = config;
        }

        public async Task UploadDocumentAsync(string filePath)
        {
            var uploader = new TransferUtility(_s3Client);

            var fileId = Guid.NewGuid().ToString("N");
            //var file = new File { Id = fileId };

            await uploader.UploadAsync(filePath, _config.AWS.S3_Bucket, fileId);

           // return new Task()
        }
    }
}
