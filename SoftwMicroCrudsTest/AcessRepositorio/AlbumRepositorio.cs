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
    }
}