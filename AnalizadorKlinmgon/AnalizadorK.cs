using System;
using System.IO;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorKlingon
{
    public class AnalizadorK
    {
        #region  Variaveis classe / Construtor

        // Variaveis
        private string[] letrasBar = null;
        private string[] letrasFoo = null;
        private string[] alfabetoKlingon = null;
        private string novaPalavra = null;
        private string resultado = null;
        private String separador = new string('-', 85);
        private string[] textoParticionado = null;

        public AnalizadorK()
        {
            this.letrasBar = new string[] {"a","b","c","d","e","g","h","i","j","m","n","o","p","q","r","t","u","v","x","y","z"};
            this.letrasFoo = new string[] {"s","l","f","w","k"};
            this.alfabetoKlingon = new string[] {"k","b","w","r","q","d","n","f","x","j","m","l","v","h","t","c","g","z","p","s"};
        }

        #endregion

        #region Funcões publicas
        public string Selecionar_Preposicoes_Klingon(string texto)
        {
            // Variaveis local
            int contPreposicao = 0;

            // Particionando texto Klingon
            textoParticionado = Particionar_Texto(texto);

            // Percorrer palavras do texto Klingon
            foreach (var palavra in textoParticionado)
            {
                bool achou = false;

                // Se tiver 3 letras
                if (palavra.Length == 3)
                {
                    // Percorrer letras da palavra
                    for(int i = 0 ; i < palavra.Length; i++ )
                    {
                        // Se a letra "d"
                        if (palavra.Substring(i, 1) == "d")
                        {
                            achou = true;
                            break;
                        }
                    }

                    // Se nao achou letra "d"
                    if (!achou)
                    {
                        // Percorrer letras bar permitidas
                        foreach (var itemLertra in letrasBar )
                        {
                            // Se letra permitida iqual a ultima da palavra
                            if (palavra.Substring(2, 1) == itemLertra)
                            {
                                // Guardar. É uma prepossicao Kligon
                                resultado += palavra + "  ";
                                contPreposicao++;
                                break;
                            }
                        }
                    }
                }
            }
            
            return resultado + Environment.NewLine + separador + Environment.NewLine + " Total de Preposições => " + contPreposicao.ToString(); ;
        }
        public string Selecionar_Verbos_Klingon(string texto)
        {
            // Variaveis locais
            string Verbos = null;
            string VerbosPrimeiraPessoa = null;
            int contVerbosPP = 0;
            int contVerbos = 0;

            // Particionando texto Klingon
            textoParticionado = Particionar_Texto(texto);

            // Percorrer palavras do texto Klingon
            foreach (var palavra in textoParticionado )
            {
                bool achou = false;

                // Se tiver 8 letras ou mais
                if (palavra.Length >= 8)
                {
                    // Percorrer letras da palavra
                    foreach (var letraFOO in letrasFoo )
                    {
                        // Se ultima letra tipo foo
                        if (palavra.Substring(palavra.Length - 1, 1) == letraFOO)
                        {
                            achou = true;
                            contVerbos++;
                            Verbos += palavra + "  ";
                            break;
                        }
                    }

                    // Se verbo
                    if(achou)
                    {
                        // Percorrer letras bar permitidas
                        foreach (var lertraBAR in letrasBar)
                        {
                            // Se letra permitida iqual a ultima da palavra
                            if (palavra.Substring(0, 1) == lertraBAR)
                            {
                                // Guardar. É um verbo na primeira pessoa
                                VerbosPrimeiraPessoa += palavra + "  ";
                                contVerbosPP++;
                                break;
                            }
                        }
                    }
                }
            }
            // Adicionando quantidade
            return Verbos + Environment.NewLine +
                  separador + Environment.NewLine +
                  " Total de Verbos => " + contVerbos.ToString() + Environment.NewLine + Environment.NewLine +
                  VerbosPrimeiraPessoa + Environment.NewLine + 
                  separador + Environment.NewLine +
                  " Total de Verbos Na Primeira Pessoa => " + contVerbosPP.ToString();
        }
        public string Selecionar_Vocabulario_Klingon(string texto)
        {
            // Variaveis Local
            var alfabetoReferencia = new Dictionary<string, string>() {
                {"k","a"},{"b","b"},{"w","c"},{"r","d"},{"q","e"},
                {"d","f"},{"n","g"},{"f","h"},{"x","i"},{"j","j"},
                {"m","k"},{"l","l"},{"v","m"},{"h","n"},{"t","o"},
                {"c","p"},{"g","q"},{"z","r"},{"p","s"},{"s","t"}
            };
            novaPalavra = string.Empty;
            Dictionary<string, string> dicionario = new Dictionary<string, string>() { };
            int contVocabulario = 0;

            // Particionando texto Klingon
            textoParticionado = Particionar_Texto(texto);

            // Elimina palavras repetidas
            var textoPalavrasUnicas = (from  n in textoParticionado select n ).Distinct();

            // Percorre palavras unicas
            foreach (var palavra in textoPalavrasUnicas )
            {
                novaPalavra = string.Empty;

                // Percorre letras da palavra
                for(int i = 0 ; i <= palavra.Length - 1; i++ )
                {
                    // Cria palavra traduzida para portugues
                    novaPalavra += alfabetoReferencia.FirstOrDefault(x => x.Key == palavra.Substring(i, 1)).Value.ToString();
                }
                // Adiciona palavra traduzida
                dicionario.Add(palavra, novaPalavra);
            }

            // Ordena palavras klingon pela palavra traduzida
            var dicionarioOrdenado = dicionario.OrderBy(x => x.Value);

            // Percorre, palavras ordenadas klingon para resultado
            foreach (var palavra in dicionarioOrdenado)
            {
                resultado += palavra.Key + "  ";
                contVocabulario++;
            }

            return "Total de Vocabulários é: => " + contVocabulario.ToString() + 
                   Environment.NewLine + separador + Environment.NewLine + resultado;
        }
        public string Selecionar_Numeros_Bonitos_Klingon(string texto)
        {
            // Variaveis Local
            Dictionary<string, Int64> dicionario = new  Dictionary<string, Int64>() { };
            int contNumerosB = 0;

            // Particionando texto Klingon
            textoParticionado = Particionar_Texto(texto);

            // Elimina palavras repetidas
            var textoPalavrasUnicas = (from n in textoParticionado select n ).Distinct();

            // Percorre palavras unicas
            foreach (var palavra in textoPalavrasUnicas )
            {
                List<Int64> numerosPalavra = new List<Int64>();

                // Percorre letras da palavra
                for (int i = 0 ; i <= palavra.Length - 1; i++ )
                {
                    // Recuperando o numeo de localização das letras do alfabeto klingon
                    numerosPalavra.Add(Array.IndexOf(alfabetoKlingon, palavra.Substring(i, 1)));
                }

                Int64 numeroKlingon = ValorDaPalavra(numerosPalavra);

                if (VeriricarSeNumeroBonito(numeroKlingon))
                {
                    resultado += numeroKlingon.ToString() + " ";
                    contNumerosB++;
                }
            }
            return "Total de Números Bonitos é: => " + contNumerosB.ToString() +
                   Environment.NewLine + separador + Environment.NewLine + resultado;
        }
        #endregion

        #region  Funcões privadas

        private string[] Particionar_Texto(string texto)
        {
            return texto.Split(new char[] { ' ' });
        }

        private bool VeriricarSeNumeroBonito(Int64 numero)
        {
            // Se numero maior ou iqual e divizivel por 3
            if (numero >= 440566)
                if (numero % 3 == 0)
                    return true;
                else
                    return false;
            return false;
        }

        private Int64 ValorDaPalavra(List<Int64> numerosPalavra)
        {
            Int64 resultado = 0;
            for (int i = 0; i < numerosPalavra.Count; i++)
            {
                resultado = resultado + numerosPalavra[i] * (Int64)Math.Pow(20, i);
            }
            return resultado;
        }

        #endregion
    }
}
