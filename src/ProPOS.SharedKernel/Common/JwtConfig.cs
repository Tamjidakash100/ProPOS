namespace ProPOS.SharedKernel.Common;

public class JwtConfig
{
    public string ValidIssuer { get; set; }
    public string ValidAudience { get; set; }
    public string Secret { get; set; }
    public double ExpiresIn { get; set; }
}
public class Domain
{
    public List<string> Client1 { get; set; }
    public List<string> Client2 { get; set; }
    public List<string> All { get; set; }
    public string DomainName { get; set; }
}
