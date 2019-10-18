﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VemProChurras
{
    public class Variaveis
    {
        //pessoas
        public double NumHomem  { get; set; }
        public double NumMulher  { get; set; }
        public double NumCrianca { get; set; }
        //carnes
        public double ValorCarneAves { get; set; }
        public double ValorCarneBovina { get; set; }
        public double ValorCarneSuina { get; set; }
        //bebidas
        public double ValorCerveja { get;  set; }
        public double ValorCaipirinha { get;  set; }
        public double ValorBeats { get; set; }
        public double ValorSuco { get; set; }
        public double ValorVodka { get; set; }
        public double ValorRefrigerante { get; set; }
        //acompanhamentos
        public double ValorArrozAGrega { get; set; }
        public double ValorQueijoCoalho { get; set; }
        public double ValorFarofa { get; set; }
        public double ValorVinagrete { get; set; }
        public double ValorSaladaMaio { get; set; }
        public double ValorPao { get; set; }
        //descartaveis
        public double ValorCopos { get; set; }
        public double ValorPratos { get; set; }
        public double ValorTalheres { get; set; }
        public double ValorCanudos { get; set; }
        public double ValorGuardanapos { get; set; }

        //Quantidade
        public double TotKgCarneBovina { get; set; }
        public double TotKgCarneSuina { get; set; }
        public double TotKgCarneAve { get; set; }

        //Valores total
        public double TotVlCarneBovina { get; set; }
        public double TotVlCarneSuina { get; set; }
        public double TotVlCarneAve { get; set; }


        //Calculos
        public double TotCarneHomem { get; set; }
        public double TotCarneMulher { get; set; }
        public double TotCarneCrianca { get; set; }
        public double TotalDeAdultos { get; set; }
        public double TotalDePessoas { get; set; }
        public double TotalDeCarnes { get; set; }
        public double TotalBebidas { get; set; }
        public double TotalAcompanhamentos { get; set; }
        public double TotalDescartaveis { get; set; }
        public double TotalQtdDeCarnes { get; set; }
        public double TotalQtdBebidas { get; set; }
        public double TotalQtdAcompanhamentos { get; set; }
        public double TotalQtdDescartaveis { get; set; }
        public double Total { get; set; }

    }

}
