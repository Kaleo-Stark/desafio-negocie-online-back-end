using desafio_negocie_online_back_end.Models;
using Npgsql;
using Dapper;

namespace desafio_negocie_online_back_end.Services{
    public static class CEPService{
        static string stringConnection ;
        static NpgsqlConnection connection;
        static CEPService(){
            stringConnection = "<String de conexão aqui>";
            connection = new NpgsqlConnection(stringConnection);
        }

        public static CEP Get(string cep){
            connection.Open();

            var cepBD = connection.QueryFirstOrDefault<CEP>("select * from api_cep where cep = @codeCEP;", new { codeCEP = cep });

            connection.Close();

            return cepBD;
        }

        public static void Add(CEP cep){
            var stringInsert = "insert into api_cep (cep,logradouro,complemento,bairro,localidade,uf,ibge,gia,ddd,siafi)"+ 
            "values (@INcep,@INlogradouro,@INcomplemento,@INbairro,@INlocalidade,@INuf,@INibge,@INgia,@INddd,@INsiafi);";

            connection.Open();

            var cepBD = connection.QueryFirstOrDefault<CEP>(stringInsert, new { 
                INcep = cep.cep,
                INlogradouro = cep.logradouro,
                INcomplemento = cep.complemento,
                INbairro = cep.bairro,
                INlocalidade = cep.localidade,
                INuf = cep.uf,
                INibge = cep.ibge,
                INgia = cep.gia,
                INddd = cep.ddd,
                INsiafi = cep.siafi
            });

            connection.Close();
        }
    }
}