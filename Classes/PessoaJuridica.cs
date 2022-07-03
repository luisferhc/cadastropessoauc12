using System.Text.RegularExpressions;
using cadastropessoauc12.Interfaces;

namespace cadastropessoauc12.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string? Cnpj { get; set; }

        public string? RazaoSocial { get; set; }

        public string Caminho { get; private set; } = "Database/PessoaJuridica.csv";



        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * .03F;

            } else if (rendimento <= 6000)
            {
                return rendimento * .05F;

            } else if (rendimento <= 10000)
            {
                return rendimento * .07F;

            } else
            {
                return rendimento * .09F;
            }
        }


        //XX.XXX.XXX/0001-xx ----- XXXXXXXX0001XX
        public bool ValidarCnpj(string cnpj)
        {

            // = Atribuição
            // == Comparação (igualdade)
            // === Comparação exata (igualdade de valor e tipo)
            bool retornoCnpjValido = Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-d{2})|(\d{14})$)");

            //if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-d{2})|(\d{14})$)"))
            if (retornoCnpjValido == true)
            {
                if (cnpj.Length == 18)
                {
                    string subStringCnpj = cnpj.Substring(11, 4);

                    if (subStringCnpj == "0001")
                    {
                        return true;
                    }


                }
                else if (cnpj.Length == 14)
                {
                    string subStringCnpj = cnpj.Substring(8, 4);

                    if (subStringCnpj == "0001")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void Inserir(PessoaJuridica pj){

            Utils.VerificarPastaArquivo(Caminho);

            string[] pjStrings = {$"{pj.Nome},{pj.RazaoSocial},{pj.Cnpj}"};

            File.AppendAllLines(Caminho, pjStrings);
        }

        public List<PessoaJuridica> LerArquivo(){

            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(Caminho);

            // Nome,98777555000198,Rzão Social
            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.Nome = atributos[0];
                cadaPj.RazaoSocial = atributos[1];
                cadaPj.Cnpj = atributos[2];

                listaPj.Add(cadaPj);
            }

            return listaPj;
        }
    }
}