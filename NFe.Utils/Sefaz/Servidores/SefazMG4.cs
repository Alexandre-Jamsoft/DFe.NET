﻿using DFe.Classes.Entidades;
using NFe.Classes.Servicos.Tipos;

namespace NFe.Utils.Sefaz.Servidores
{
    public class SefazMG4 : SefazAmbienteNacional4
    {
        public SefazMG4() : base()
        {
            EstadoReferente = Estado.MG;
            EventoCceCancelamento = VersaoServico.ve400;
            NfeConsultaCadastro = VersaoServico.ve200;
            NfeRecepcao = VersaoServico.ve310;
            NfeRetornoRecepcao = VersaoServico.ve310;
            NfeInutilizacao = VersaoServico.ve400;
            NfeConsultaProtocolo = VersaoServico.ve400;
            NfeStatusServico = VersaoServico.ve400;
            NfeAutorizacao = VersaoServico.ve400;
            NfeRetornoAutorizacao = VersaoServico.ve400;
        }

        public override Estado EstadoReferente { get; set; }
        public override VersaoServico EventoCceCancelamento { get; set; }
        public override VersaoServico NfeConsultaCadastro { get; set; }
        public override VersaoServico NfeRecepcao { get; set; }
        public override VersaoServico NfeRetornoRecepcao { get; set; }
        public override VersaoServico NfeInutilizacao { get; set; }
        public override VersaoServico NfeConsultaProtocolo { get; set; }
        public override VersaoServico NfeStatusServico { get; set; }
        public override VersaoServico NfeAutorizacao { get; set; }
        public override VersaoServico NfeRetornoAutorizacao { get; set; }
    }
}