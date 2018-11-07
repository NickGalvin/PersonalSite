using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Site.Core.Upload
{
    public class FileRepository
    {
        private AmazonS3Client _s3Client;

        public FileRepository()
        {
            _s3Client = new AmazonS3Client(RegionEndpoint.USEast2);
        }

        public async void UploadDocument(string filePath, string rename = "")
        {
            var uploader = new TransferUtility(_s3Client);
            await uploader.UploadAsync(filePath, bucketName);

        }
    }
}
