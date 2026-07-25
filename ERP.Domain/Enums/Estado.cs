using Ardalis.SmartEnum;

namespace ERP.Domain.Enums
{
    public sealed class Estado : SmartEnum<Estado, string>
    {
        public static readonly Estado AC = new("Acre", "AC");
        public static readonly Estado AL = new("Alagoas", "AL");
        public static readonly Estado AP = new("Amapá", "AP");
        public static readonly Estado AM = new("Amazonas", "AM");
        public static readonly Estado BA = new("Bahia", "BA");
        public static readonly Estado CE = new("Ceará", "CE");
        public static readonly Estado DF = new("Distrito Federal", "DF");
        public static readonly Estado ES = new("Espírito Santo", "ES");
        public static readonly Estado GO = new("Goiás", "GO");
        public static readonly Estado MA = new("Maranhão", "MA");
        public static readonly Estado MT = new("Mato Grosso", "MT");
        public static readonly Estado MS = new("Mato Grosso do Sul", "MS");
        public static readonly Estado MG = new("Minas Gerais", "MG");
        public static readonly Estado PA = new("Pará", "PA");
        public static readonly Estado PB = new("Paraíba", "PB");
        public static readonly Estado PR = new("Paraná", "PR");
        public static readonly Estado PE = new("Pernambuco", "PE");
        public static readonly Estado PI = new("Piauí", "PI");
        public static readonly Estado RJ = new("Rio de Janeiro", "RJ");
        public static readonly Estado RN = new("Rio Grande do Norte", "RN");
        public static readonly Estado RS = new("Rio Grande do Sul", "RS");
        public static readonly Estado RO = new("Rondônia", "RO");
        public static readonly Estado RR = new("Roraima", "RR");
        public static readonly Estado SC = new("Santa Catarina", "SC");
        public static readonly Estado SP = new("São Paulo", "SP");
        public static readonly Estado SE = new("Sergipe", "SE");
        public static readonly Estado TO = new("Tocantins", "TO");

        private Estado(string estado, string uf) : base(estado, uf)
        {
        }
    }
}
