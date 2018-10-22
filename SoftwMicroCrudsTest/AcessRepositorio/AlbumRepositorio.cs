using SoftwMicroCrudsTest.AcessContext;
using SoftwMicroCrudsTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwMicroCrudsTest.AcessRepositorio
{
    public class AlbumRepositorio
    {
        private readonly Contexto contexto;

        public AlbumRepositorio()
        {
            contexto = new Contexto();
        }

        public List<Album> ListarTodos()
        {
            var albuns = new List<Album>();

            const string strQuery = "SELECT codigo, nome, data_criacao, data_atualizacao FROM tb_album";

            var rows = contexto.ExecutaComandoComRetorno(strQuery);
            foreach (var row in rows)
            {
                var tempAlbum = new Album
                {
                    Codigo = int.Parse(!string.IsNullOrEmpty(row["codigo"]) ? row["codigo"] : "0"),
                    Nome = row["nome"],
                    DataCriacao = Convert.ToDateTime(row["data_criacao"]),
                    DataAtualizacao = Convert.ToDateTime(row["data_atualizacao"]),
                };
                albuns.Add(tempAlbum);
            }

            return albuns;
        }

        private int Inserir(Album album)
        {
            const string commandText = " INSERT INTO tB_album (nome,data_criacao) VALUES (@nome,@data_criacao) ";

            var parameters = new Dictionary<string, object>
            {
                {"nome", album.Nome},
                {"data_criacao", album.DataCriacao}
            };

            return contexto.ExecutaComando(commandText, parameters);
        }

        private int Alterar(Album album)
        {
            var commandText = " UPDATE tB_album SET ";
            commandText += " nome = @Nome ";
            commandText += " data_atualizacao = @Data_atualizacao ";
            commandText += " WHERE codigo = @Codigo ";


            var parameters = new Dictionary<string, object>
            {
                {"Codigo",  album.Codigo},
                 {"Nome",  album.Nome},
                {"Data_atualizacao", album.DataAtualizacao}
            };

            return contexto.ExecutaComando(commandText, parameters);
        }

        public void Salvar(Album album)
        {
            if (album.Codigo > 0) { 
                album.DataAtualizacao = DateTime.Now;
                Alterar(album);
            }
            else
                Inserir(album);
        }

    }
}