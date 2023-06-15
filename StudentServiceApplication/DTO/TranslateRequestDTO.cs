namespace StudentServiceApplication.DTO
{
    public record TranslateRequestDTO
    {
        public string sourceLanguageCode;
        public string targetLanguageCode;
        public List<string> texts;
        public string folderId;
        public TranslateRequestDTO(string sourceLanguageCode, string targetLanguageCode, List<string> texts, string folderId)
        {
            this.sourceLanguageCode = sourceLanguageCode;
            this.targetLanguageCode = targetLanguageCode;
            this.texts = texts;
            this.folderId = folderId;
        }
    }
}
