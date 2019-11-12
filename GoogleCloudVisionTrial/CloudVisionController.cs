using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Vision.V1;

namespace GoogleCloudVisionTrial
{
    public class CloudVisionController
    {
        /// <summary>
        /// Cloud Vision用のImageの型に変換する
        /// </summary>
        private Image ConvertImageFormatForV1(System.Drawing.Image img)
        {
            System.Drawing.ImageConverter imgConv = new System.Drawing.ImageConverter();
            byte[] b = (byte[])imgConv.ConvertTo(img, typeof(byte[]));
            Image ret = Image.FromBytes(b);
            return ret;
        }
        /// <summary>
        /// 画像から文字情報を検出する
        /// </summary>
        /// <returns>文字情報</returns>
        public string ReadTextFromImage(System.Drawing.Image img)
        {
            Image target = ConvertImageFormatForV1(img);
            string ret = "";
            var client = ImageAnnotatorClient.Create();
            var response = client.DetectText(target);
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                {
                    ret += annotation.Description + System.Environment.NewLine;
                Console.WriteLine(annotation.Description);
                }
            }
            return ret;
        }
    }
}
