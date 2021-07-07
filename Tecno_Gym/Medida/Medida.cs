using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecno_Gym.Medida
{
    public class Medida
    {
        int id_medida;
        double altura,peitoral,brc_esquerdo,brc_direito,pnt_direita,pnt_esquerda,quadril,coxa_direita,coxa_esquerda;
        DateTime datamedida;
        int id_cliente;
        string nome_cliente;


        public void novo()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into medida (altura, peitoral, brc_esquerdo, brc_direito, pnt_direita,pnt_esquerda,quadril,coxa_direita,coxa_esquerda,data_medida,id_cliente) values(:altura, :peitoral, :brc_esquerdo, :brc_direito, :pnt_direita, :pnt_esquerda, :quadril, :coxa_direita, :coxa_esquerda, :data_medida, :id_cliente)", con);
                cmd.Parameters.Add(new NpgsqlParameter("altura", altura));
                cmd.Parameters.Add(new NpgsqlParameter("peitoral", peitoral));
                cmd.Parameters.Add(new NpgsqlParameter("brc_esquerdo", brc_esquerdo));
                cmd.Parameters.Add(new NpgsqlParameter("brc_direito", brc_direito));
                cmd.Parameters.Add(new NpgsqlParameter("pnt_direita", pnt_direita));
                cmd.Parameters.Add(new NpgsqlParameter("pnt_esquerda", pnt_esquerda));
                cmd.Parameters.Add(new NpgsqlParameter("quadril", quadril));
                cmd.Parameters.Add(new NpgsqlParameter("coxa_direita", coxa_direita));
                cmd.Parameters.Add(new NpgsqlParameter("coxa_esquerda", coxa_esquerda));
                cmd.Parameters.Add(new NpgsqlParameter("data_medida", datamedida));
                cmd.Parameters.Add(new NpgsqlParameter("id_cliente", id_cliente));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void atualizar()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update medida set altura = :altura, peitoral = :peitoral, brc_esquerdo = :brc_esquerdo, brc_direito = :brc_direito, pnt_direita = :pnt_direita ,pnt_esquerda = :pnt_esquerda,quadril = :quadril, coxa_direita = :coxa_direita, coxa_esquerda = :coxa_esquerda,data_medida = :data_medida,id_cliente = :id_cliente where id_medida = :id_medida", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_medida", id_medida));
                cmd.Parameters.Add(new NpgsqlParameter("altura", altura));
                cmd.Parameters.Add(new NpgsqlParameter("peitoral", peitoral));
                cmd.Parameters.Add(new NpgsqlParameter("brc_esquerdo", brc_esquerdo));
                cmd.Parameters.Add(new NpgsqlParameter("brc_direito", brc_direito));
                cmd.Parameters.Add(new NpgsqlParameter("pnt_direita", pnt_direita));
                cmd.Parameters.Add(new NpgsqlParameter("pnt_esquerda", pnt_esquerda));
                cmd.Parameters.Add(new NpgsqlParameter("quadril", quadril));
                cmd.Parameters.Add(new NpgsqlParameter("coxa_direita", coxa_direita));
                cmd.Parameters.Add(new NpgsqlParameter("coxa_esquerda", coxa_esquerda));
                cmd.Parameters.Add(new NpgsqlParameter("data_medida", datamedida));
                cmd.Parameters.Add(new NpgsqlParameter("id_cliente", id_cliente));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void excluir()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from medida where id_medida = :id_medida", con);                
                cmd.Parameters.Add(new NpgsqlParameter("id_medida", id_medida));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void SetIdMedida(int idT)
        {
            id_medida = idT;
        }

        public double GetIdMedida()
        {
            return id_medida;
        }

        public void SetAltura(double alturaT)
        {
            altura = alturaT;
        }

        public double GetAltura()
        {
            return altura;
        }

        public void SetPeitoral(double peitoralT)
        {
            peitoral = peitoralT;
        }

        public double GetPeitoral()
        {
            return peitoral;
        }

        public void SetBrc_esquerdo(double brc_esquerdoT)
        {
            brc_esquerdo = brc_esquerdoT;
        }

        public double GetBrc_esquerdo()
        {
            return brc_esquerdo;
        }


        public void SetBrc_direito(double brc_direitoT)
        {
            brc_direito = brc_direitoT;
        }

        public double GetBrc_direito()
        {
            return brc_direito;
        }

        public void SetPnt_direita(double pnt_direitaT)
        {
            pnt_direita = pnt_direitaT;
        }

        public double GetPnt_direita()
        {
            return pnt_direita;
        }

        public void SetPnt_esquerda(double pnt_esquerdaT)
        {
            pnt_esquerda = pnt_esquerdaT;
        }

        public double GetPnt_esquerda()
        {
            return pnt_esquerda;
        }

        public void SetQuadril(double quadrilT)
        {
            quadril = quadrilT;
        }

        public double GetQuadril()
        {
            return quadril;
        }

        public void SetCoxa_direita(double coxa_direitaT)
        {
            coxa_direita = coxa_direitaT;
        }

        public double GetCoxa_direita()
        {
            return coxa_direita;
        }

        public void SetCoxa_esquerda(double coxa_esquerdaT)
        {
            coxa_esquerda = coxa_esquerdaT;
        }

        public double GetCoxa_esquerda()
        {
            return coxa_esquerda;
        }

        public void SetDataMedida(DateTime datamedidaT)
        {
            datamedida = datamedidaT;
        }

        public DateTime GetDataMedida()
        {
            return datamedida;
        }

        public void SetIdCliente(int id_clienteT)
        {
            id_cliente = id_clienteT;
        }

        public int GetIdCliente()
        {
            return id_cliente;
        }

        public void SetNomeCliente(string nomeT)
        {
            nome_cliente = nomeT;
        }

        public string GetNomeCliente()
        {
            return nome_cliente;
        }

    }
}
