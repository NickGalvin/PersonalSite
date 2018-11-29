using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
using PersonalSite.Server;
using System;
using System.Collections.Generic;
using System.Text;

namespace Site.Core.Upload
{
    public class FileRepository
    {
        private AmazonS3Client _s3Client;
        private readonly SiteConfig _config;

        public FileRepository(SiteConfig config)
        {
            _s3Client = new AmazonS3Client(config.AWS.AccessKey, config.AWS.SecretKey, RegionEndpoint.USEast2);
            _config = config;
        }

        public async void UploadDocument(string filePath, string rename = "")
        {
            var uploader = new TransferUtility(_s3Client);
            await uploader.UploadAsync(filePath, _config.AWS.S3_Bucket);
        }
    }
}
