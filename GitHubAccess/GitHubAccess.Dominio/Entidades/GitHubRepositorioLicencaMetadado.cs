namespace GitHubAccess.Dominio.Entidades
{
    public class GitHubRepositorioLicencaMetadado
    {
        public GitHubRepositorioLicencaMetadado(string key, string nodeId, string name, string spdxId, string url, bool featured)
        {
            Key = key;
            NodeId = nodeId;
            Name = name;
            SpdxId = spdxId;
            Url = url;
            Featured = featured;
        }

        public string Key { get; protected set; }
        public string NodeId { get; protected set; }
        public string Name { get; protected set; }
        public string SpdxId { get; protected set; }
        public string Url { get; protected set; }
        public bool Featured { get; protected set; }
    }
}
