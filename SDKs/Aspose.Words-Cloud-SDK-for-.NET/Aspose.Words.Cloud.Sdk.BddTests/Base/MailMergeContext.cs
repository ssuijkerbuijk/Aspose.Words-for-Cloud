namespace Aspose.Words.Cloud.Sdk.BddTests.Base
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Requests;

    /// <summary>
    /// This class contains implementation of all required operations for mail merge
    /// </summary>
    public class MailMergeContext : BaseContext
    {
        /// <summary>
        /// File that stores body data
        /// </summary>
        public string FileWithBodyData { get; set; }

        /// <summary>
        /// Destination file name
        /// </summary>
        public string DestinationFileName { get; set; }

        /// <summary>
        /// Response with document
        /// </summary>
        public DocumentResponse DocumentResponse { get; set; }

        /// <summary>
        /// Sets with regions option for mail merge
        /// </summary>
        public bool? WithRegions { get; set; }

        /// <summary>
        /// Sets whether use paragraph as region or not
        /// </summary>
        public bool? UseWholeParagraphAsRegion { get; set; }

        /// <summary>
        /// Sets cleanup options like 'UnusedRegions', 'UnusedFileds', 'EmptyParagraphs'
        /// </summary>
        public string Cleanup { get; set; }

        /// <summary>
        /// Executes template
        /// </summary>
        public void ExecuteTemplate()
        {
            var request = new PostExecuteTemplateRequest(
                this.FileName,
                File.ReadAllText(Path.Combine(this.TestDataPath, this.FileWithBodyData)),
                destFileName: this.DestinationFileName,
                withRegions: this.WithRegions,
                useWholeParagraphAsRegion: this.UseWholeParagraphAsRegion,
                cleanup: this.Cleanup);
            if (this.WithRegions.HasValue || this.UseWholeParagraphAsRegion.HasValue || !string.IsNullOrEmpty(this.Cleanup))
            {
                var req = new PutExecuteTemplateOnlineRequest(
                    new MemoryStream(File.ReadAllBytes(Path.Combine(this.TestDataPath, this.FileName))),
                    new MemoryStream(File.ReadAllBytes(Path.Combine(this.TestDataPath, this.FileWithBodyData))),
                    this.Cleanup,
                    this.UseWholeParagraphAsRegion,
                    this.WithRegions);
                var resp = this.MethodsApi.PutExecuteTemplateOnline(req);
                File.WriteAllBytes(Path.Combine(this.TestDataPath, this.FileName.Split('.')[0] + "Result.doc"), ((MemoryStream)resp).ToArray());
            }

            this.DocumentResponse = this.MethodsApi.PostExecuteTemplate(request);
        }
    }
}