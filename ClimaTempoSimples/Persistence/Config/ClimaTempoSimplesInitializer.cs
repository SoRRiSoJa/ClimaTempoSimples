using ClimaTempoSimples.Models;
using System;
using System.Collections.Generic;

namespace ClimaTempoSimples.Persistence.Config
{
    public class ClimaTempoSimplesInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ClimaTempoSimplesContext>
    {
        protected override void Seed(ClimaTempoSimplesContext context)
        {
            var listaEstados = new List<Estado> {
                new Estado() { Id=1,Nome="Acre",UF="AC" },
                new Estado() { Id=2,Nome="Alagoas",UF="AL" },
                new Estado() { Id=3,Nome="Amazonas",UF="AM" },
                new Estado() { Id=4,Nome="Amapá",UF="AP" },
                new Estado() { Id=5,Nome="Bahia",UF="BA" },
                new Estado() { Id=6,Nome="Ceará",UF="CE" },
                new Estado() { Id=7,Nome="Distrito Federal",UF="DF" },
                new Estado() { Id=8,Nome="Espirito Santo",UF="ES" },
                new Estado() { Id=9,Nome="Goiás",UF="GO" },
                new Estado() { Id=10,Nome="Maranhão",UF="MA" },
                new Estado() { Id=11,Nome="Minas Gerais",UF="MG" },
                new Estado() { Id=12,Nome="Mato Grosso do Sul",UF="MS" },
                new Estado() { Id=13,Nome="Mato Grosso",UF="MT" },
                new Estado() { Id=14,Nome="Pará",UF="PA" },
                new Estado() { Id=15,Nome="Paraíba",UF="PB" },
                new Estado() { Id=16,Nome="Pernambuco",UF="PE" },
                new Estado() { Id=17,Nome="Piauí",UF="PI" },
                new Estado() { Id=18,Nome="Paraná",UF="PR" },
                new Estado() { Id=19,Nome="Rio de Janeiro",UF="RJ" },
                new Estado() { Id=20,Nome="Rio Grande do Norte",UF="RN" },
                new Estado() { Id=21,Nome="Rondônia",UF="RO" },
                new Estado() { Id=22,Nome="Roraima",UF="RR" },
                new Estado() { Id=23,Nome="Rio Grande do Sul",UF="RS" },
                new Estado() { Id=24,Nome="Santa Catarina",UF="SC" },
                new Estado() { Id=25,Nome="Sergipe",UF="SE" },
                new Estado() { Id=26,Nome="São Paulo",UF="SP" },
                new Estado() { Id=27,Nome="Tocantins",UF="TO" }
            };
            context.Estados.AddRange(listaEstados);
            context.SaveChanges();
            var listaCidades = new List<Cidade>
            {
                new Cidade(){Id=1,Nome="São Paulo",EstadoId=26 },
                new Cidade(){Id=2,Nome="Rio de Janeiro",EstadoId=19 },
                new Cidade(){Id=3,Nome="Campo Grande",EstadoId=12 },
                new Cidade(){Id=4,Nome="Cuiabá",EstadoId=13 },
                new Cidade(){Id=5,Nome="Goiânea",EstadoId=9 },
                new Cidade(){Id=6,Nome="Curitiba",EstadoId=18 },
            };
            context.Cidades.AddRange(listaCidades);
            context.SaveChanges();

            var listaPrevisoes = new List<PrevisaoClima>();
            Random rnd = new Random();
            //Previsão sete dias Cidade São Paulo
            //for (int i = 1; i < 8; i++)
            //{
            //listaPrevisoes.Add(new PrevisaoClima() { Id = i, CidadeId = 1, DataPrivisao = (i==1)?DateTime.Now: DateTime.Now.AddDays(i), TemperaturaMaxima = rnd.Next(28, 42), TempereturaMinima = rnd.Next(15, 22) });
            //}
            ////Previsão sete dias Rio Janeiro
            //for (int i = 1; i < 8; i++)
            //{
            //listaPrevisoes.Add(new PrevisaoClima() { Id = i, CidadeId = 2, DataPrivisao = (i == 1) ? DateTime.Now : DateTime.Now.AddDays(i), TemperaturaMaxima = rnd.Next(33, 44), TempereturaMinima = rnd.Next(23, 28) });
            //}
            ////Previsão sete dias Campo Grande
            //for (int i = 1; i < 8; i++)
            //{
            //listaPrevisoes.Add(new PrevisaoClima() { ID = i, CidadeID = 3, DataPrivisao = (i == 1) ? DateTime.Now : DateTime.Now.AddDays(i), TemperaturaMaxima = rnd.Next(33, 39), TempereturaMinima = rnd.Next(22, 26) });
            //}
            ////Previsão sete dias Cuiabá
            //for (int i = 1; i < 8; i++)
            //{
            //listaPrevisoes.Add(new PrevisaoClima() { ID = i, CidadeID = 4, DataPrivisao = (i == 1) ? DateTime.Now : DateTime.Now.AddDays(i), TemperaturaMaxima = rnd.Next(36, 44), TempereturaMinima = rnd.Next(24, 28) });
            //}
            ////Previsão sete dias Goiânea
            //for (int i = 1; i < 8; i++)
            //{
            //listaPrevisoes.Add(new PrevisaoClima() { ID = i, CidadeID = 5, DataPrivisao = (i == 1) ? DateTime.Now : DateTime.Now.AddDays(i), TemperaturaMaxima = rnd.Next(30, 38), TempereturaMinima = rnd.Next(20, 24) });
            //}
            ////Previsão sete dias Curitiba
            //for (int i = 1; i < 8; i++)
            //{
            //listaPrevisoes.Add(new PrevisaoClima() { ID = i, CidadeID = 6, DataPrivisao = (i == 1) ? DateTime.Now : DateTime.Now.AddDays(i), TemperaturaMaxima = rnd.Next(28, 33), TempereturaMinima = rnd.Next(15, 21) });
            //}
            context.PrevisoesClima.AddRange(listaPrevisoes);
            context.SaveChanges();
        }
    }
}