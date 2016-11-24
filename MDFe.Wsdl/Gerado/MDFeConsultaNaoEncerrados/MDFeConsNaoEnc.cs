﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
/********************************************************************************/
/* Projeto: Biblioteca ZeusMDFe                                                 */
/* Biblioteca C# para emissão de Manifesto Eletrônico Fiscal de Documentos      */
/* (https://mdfe-portal.sefaz.rs.gov.br/                                        */
/*                                                                              */
/* Direitos Autorais Reservados (c) 2014 Adenilton Batista da Silva             */
/*                                       Zeusdev Tecnologia LTDA ME             */
/*                                                                              */
/*  Você pode obter a última versão desse arquivo no GitHub                     */
/* localizado em https://github.com/adeniltonbs/Zeus.Net.NFe.NFCe               */
/*                                                                              */
/*                                                                              */
/*  Esta biblioteca é software livre; você pode redistribuí-la e/ou modificá-la */
/* sob os termos da Licença Pública Geral Menor do GNU conforme publicada pela  */
/* Free Software Foundation; tanto a versão 2.1 da Licença, ou (a seu critério) */
/* qualquer versão posterior.                                                   */
/*                                                                              */
/*  Esta biblioteca é distribuída na expectativa de que seja útil, porém, SEM   */
/* NENHUMA GARANTIA; nem mesmo a garantia implícita de COMERCIABILIDADE OU      */
/* ADEQUAÇÃO A UMA FINALIDADE ESPECÍFICA. Consulte a Licença Pública Geral Menor*/
/* do GNU para mais detalhes. (Arquivo LICENÇA.TXT ou LICENSE.TXT)              */
/*                                                                              */
/*  Você deve ter recebido uma cópia da Licença Pública Geral Menor do GNU junto*/
/* com esta biblioteca; se não, escreva para a Free Software Foundation, Inc.,  */
/* no endereço 59 Temple Street, Suite 330, Boston, MA 02111-1307 USA.          */
/* Você também pode obter uma copia da licença em:                              */
/* http://www.opensource.org/licenses/lgpl-license.php                          */
/*                                                                              */
/* Zeusdev Tecnologia LTDA ME - adenilton@zeusautomacao.com.br                  */
/* http://www.zeusautomacao.com.br/                                             */
/* Rua Comendador Francisco josé da Cunha, 111 - Itabaiana - SE - 49500-000     */
/********************************************************************************/
using MDFe.Wsdl.Configuracao;

namespace MDFe.Wsdl.Gerado.MDFeConsultaNaoEncerrados
{ // 
// This source code was auto-generated by wsdl, Version=4.6.1055.0.
// 


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="MDFeConsNaoEncSoap12", Namespace="http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeConsNaoEnc")]
    public partial class MDFeConsNaoEnc : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
        private mdfeCabecMsg mdfeCabecMsgValueField;
    
        private System.Threading.SendOrPostCallback mdfeConsNaoEncOperationCompleted;
    
        /// <remarks/>
        public MDFeConsNaoEnc(WsdlConfiguracao configuracao) {
            this.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
            this.Url = configuracao.Url;
            this.mdfeCabecMsgValue = new mdfeCabecMsg
            {
                cUF = configuracao.CodigoIbgeEstado,
                versaoDados = configuracao.Versao
            };
            this.ClientCertificates.Add(configuracao.CertificadoDigital);
            Timeout = configuracao.TimeOut;
        }
    
        public mdfeCabecMsg mdfeCabecMsgValue {
            get {
                return this.mdfeCabecMsgValueField;
            }
            set {
                this.mdfeCabecMsgValueField = value;
            }
        }
    
        /// <remarks/>
        public event mdfeConsNaoEncCompletedEventHandler mdfeConsNaoEncCompleted;
    
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("mdfeCabecMsgValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.InOut)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeConsNaoEnc/mdfeConsNaoEnc", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeConsNaoEnc")]
        public System.Xml.XmlNode mdfeConsNaoEnc([System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeConsNaoEnc")] System.Xml.XmlNode mdfeDadosMsg) {
            object[] results = this.Invoke("mdfeConsNaoEnc", new object[] {
                mdfeDadosMsg});
            return ((System.Xml.XmlNode)(results[0]));
        }
    
        /// <remarks/>
        public System.IAsyncResult BeginmdfeConsNaoEnc(System.Xml.XmlNode mdfeDadosMsg, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("mdfeConsNaoEnc", new object[] {
                mdfeDadosMsg}, callback, asyncState);
        }
    
        /// <remarks/>
        public System.Xml.XmlNode EndmdfeConsNaoEnc(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Xml.XmlNode)(results[0]));
        }
    
        /// <remarks/>
        public void mdfeConsNaoEncAsync(System.Xml.XmlNode mdfeDadosMsg) {
            this.mdfeConsNaoEncAsync(mdfeDadosMsg, null);
        }
    
        /// <remarks/>
        public void mdfeConsNaoEncAsync(System.Xml.XmlNode mdfeDadosMsg, object userState) {
            if ((this.mdfeConsNaoEncOperationCompleted == null)) {
                this.mdfeConsNaoEncOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmdfeConsNaoEncOperationCompleted);
            }
            this.InvokeAsync("mdfeConsNaoEnc", new object[] {
                mdfeDadosMsg}, this.mdfeConsNaoEncOperationCompleted, userState);
        }
    
        private void OnmdfeConsNaoEncOperationCompleted(object arg) {
            if ((this.mdfeConsNaoEncCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.mdfeConsNaoEncCompleted(this, new mdfeConsNaoEncCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
    
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeConsNaoEnc")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeConsNaoEnc", IsNullable=false)]
    public partial class mdfeCabecMsg : System.Web.Services.Protocols.SoapHeader {
    
        private string cUFField;
    
        private string versaoDadosField;
    
        private System.Xml.XmlAttribute[] anyAttrField;
    
        /// <remarks/>
        public string cUF {
            get {
                return this.cUFField;
            }
            set {
                this.cUFField = value;
            }
        }
    
        /// <remarks/>
        public string versaoDados {
            get {
                return this.versaoDadosField;
            }
            set {
                this.versaoDadosField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
    public delegate void mdfeConsNaoEncCompletedEventHandler(object sender, mdfeConsNaoEncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class mdfeConsNaoEncCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
        private object[] results;
    
        internal mdfeConsNaoEncCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
            this.results = results;
            }
    
        /// <remarks/>
        public System.Xml.XmlNode Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
}