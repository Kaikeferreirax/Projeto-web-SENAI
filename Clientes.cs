namespace Projeto_Web_Lh_Pets_versão_1
{
    class Clientes
    {
        public string? cpf_cnpj {get; set;}
        public required string nome {get; set;}
        public required string endereco {get; set;}
        public required string rg_ie {get; set;}
        public required string tipo {get; set;}
        public float valor {get; set;}
        public float valor_imposto {get; set;}
        public float total {get; set;}
    }
}