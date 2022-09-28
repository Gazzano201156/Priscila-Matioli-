using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Aluno
    {

        private string CPF;
        private string Nome;
        private string Rua;
        private string Numero;
        private string Bairro;
        private string Complemento;
        private string CEP;
        private string Cidade;
        private string Estado;
        private string Telefone;
        private string Email;
        //  private byte[] Foto;
        private bool Ativo;



        public Aluno(string cpf, string nome, string rua, string numero, string bairro, string complemento, string cep, string cidade, string estado, string telefone, string email)
        {

            DAO_Conexao.getConexao("143.106.241.3.3306", "cl201288", "cl201288", "cl*05062006");
            setCPF(cpf);
            setNome(nome);
            setRua(rua);
            setNumero(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setCEP(cep);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);

        }

        public void setCPF(string cpf)
        {
            this.CPF = cpf;
        }

        public string getCPF()
        {
            return this.CPF;
        }
        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }
        public string getNome()
        {
            return this.Nome;
        }
        public void setRua(string rua)
        {
            this.Rua = rua;

        }
        public string getRua()
        {
            return this.Rua;
        }
        public void setNumero(string numero)
        {
            this.Numero = numero;
        }
        public string getNumero()
        {
            return this.Numero;
        }
        public void setBairro(string bairro)
        {
            this.Bairro = bairro;
        }
        public string getBairro()
        {
            return this.Bairro;
        }
        public void setComplemento(string complemento)
        {
            this.Complemento = complemento;
        }
        public string getComplemento()
        {
            return this.Complemento;
        }
        public void setCEP(string cep)
        {
            this.CEP = cep;
        }
        public string getCEP()
        {
            return this.CEP;
        }
        public void setCidade(string cidade)
        {
            this.Cidade = cidade;
        }
        public string getCidade()
        {
            return this.Cidade;
        }
        public void setEstado(string estado)
        {
            this.Estado = estado;
        }
        public string getEstado()
        {
            return this.Estado;
        }
        public void setTelefone(string telefone)
        {
            this.Telefone = telefone;
        }
        public string getTelefone()
        {
            return this.Telefone;
        }
        public void setEmail(string email)
        {
            this.Email = email;
        }
        public string getEmail()
        {
            return this.Email;
        }



        public bool CadastrarAluno()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("Insert into Estudio_Aluno(CPFAluno, NomeAluno, RuaAluno, NumeroAluno, BairroAluno, ComplementoAluno, CEPAluno, CidadeAluno, EstadoAluno, TelefoneAluno, EmailAluno) values('" + CPF + "','" + Nome + "','" + Rua + "','" + Numero + "','" + Bairro + "','" + Complemento + "','" + CEP + "','" + Cidade + "','" + Estado + "','" + Telefone + "', '" + Email + "')" + " ", DAO_Conexao.con);
                //insere.Parameters.AddWithValue("foto",this.foto);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;

        }
    }
}





