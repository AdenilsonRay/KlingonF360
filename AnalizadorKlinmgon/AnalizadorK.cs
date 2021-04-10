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
        #region  Variáveis classe / Construtor

        // Variaveis
        private string[] letrasBar = null;
        private string[] letrasFoo = null;
        private string[] alfabetoKlingon = null;
        private string novaPalavra = null;
        private String separador = new string('-', 85);
        private string[] textoParticionado = null;

        public AnalizadorK()
        {
            this.letrasBar = new string[] {"a","b","c","d","e","g","h","i","j","m","n","o","p","q","r","t","u","v","x","y","z"};
            this.letrasFoo = new string[] {"s","l","f","w","k"};
            this.alfabetoKlingon = new string[] {"k","b","w","r","q","d","n","f","x","j","m","l","v","h","t","c","g","z","p","s"};
        }

        #endregion

        #region Funções Públicas
        public string Selecionar_Preposicoes_Klingon(string texto)
        {
            // Variaveis local
            int contPreposicao = 0;
            string resultadoPreposicao = string.Empty;

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
                        // Se ocorre letra "d"
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
                            // Se ultima letra tipo BAR permitida
                            if (palavra.Substring(2, 1) == itemLertra)
                            {
                                // Guardar. É uma prepossicao Kligon
                                resultadoPreposicao += palavra + "  ";
                                contPreposicao++;
                                break;
                            }
                        }
                    }
                }
            }
            
            return resultadoPreposicao + Environment.NewLine + separador + Environment.NewLine + " Total de Preposições => " + contPreposicao.ToString(); ;
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

            // Percorrer palavras do texto
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
                        // Percorrer letras bar
                        foreach (var lertraBAR in letrasBar)
                        {
                            // Se primeira letra tipo BAR
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
            string novaPalavra = string.Empty;
            int contVocabulario = 0;
            string resultadoVocabulario = string.Empty;
            Dictionary<string, string> dicionario = new Dictionary<string, string>() { };
            var alfabetoReferencia = new Dictionary<string, string>() {
                {"k","a"},{"b","b"},{"w","c"},{"r","d"},{"q","e"},
                {"d","f"},{"n","g"},{"f","h"},{"x","i"},{"j","j"},
                {"m","k"},{"l","l"},{"v","m"},{"h","n"},{"t","o"},
                {"c","p"},{"g","q"},{"z","r"},{"p","s"},{"s","t"}
            };

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
                    // Traduz letra para portugues
                    novaPalavra += alfabetoReferencia.FirstOrDefault(x => x.Key == palavra.Substring(i, 1)).Value.ToString();
                }
                // Adiciona palavra traduzida
                dicionario.Add(palavra, novaPalavra);
            }

            // Ordena palavras klingon pela palavra traduzida
            var dicionarioOrdenado = dicionario.OrderBy(x => x.Value);

            // Percorre palavras ordenadas klingon
            foreach (var palavra in dicionarioOrdenado)
            {
                resultadoVocabulario += palavra.Key + "  ";
                contVocabulario++;
            }

            return " Total de Vocabulários é: => " + contVocabulario.ToString() + 
                   Environment.NewLine + separador + Environment.NewLine + resultadoVocabulario;
        }
        public string Selecionar_Numeros_Bonitos_Klingon(string texto)
        {
            // Variaveis Local
            int contNumerosB = 0;
            string resultadoNumeros = string.Empty;

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
                    // Recuperando numero de posição das letras no alfabeto klingon
                    numerosPalavra.Add(Array.IndexOf(alfabetoKlingon, palavra.Substring(i, 1)));
                }

                // Calcula valor da palavra
                Int64 numeroKlingon = Valor_DaPalavra(numerosPalavra);

                // Seleciona os numeros bonitos
                if (Verificar_SeNumero_Bonito(numeroKlingon))
                {
                    resultadoNumeros += numeroKlingon.ToString() + " ";
                    contNumerosB++;
                }
            }
            return " Total de Números Bonitos é: => " + contNumerosB.ToString() +
                   Environment.NewLine + separador + Environment.NewLine + resultadoNumeros;
        }
        #endregion

        #region  Funções privadas

        private string[] Particionar_Texto(string texto)
        {
            return texto.Split(new char[] { ' ' });
        }

        private bool Verificar_SeNumero_Bonito(Int64 numero)
        {
            // Se numero maior ou iqual e divizivel por 3
            if (numero >= 440566 & numero % 3 == 0)
                return true;
            else
            return false;
        }

        private Int64 Valor_DaPalavra(List<Int64> numerosPalavra)
        {
            Int64 resultado = 0;

            // Calculando para base 20 os numeros
            for (int i = 0; i < numerosPalavra.Count; i++)
            {
                resultado += numerosPalavra[i] * (Int64)Math.Pow(20, i);
            }
            return resultado;
        }

        #endregion
    }
}
