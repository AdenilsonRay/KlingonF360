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
        private int cont = 0;
        private int cont1 = 0;

        public AnalizadorK()
        {
            this.letrasBar = new string[] {"a","b","c","d","e","g","h","i","j","m","n","o","p","q","r","t","u","v","x","y","z"};
            this.letrasFoo = new string[] {"s","l","f","w","k"};
            this.alfabetoKlingon = new string[] {"k","b","w","r","q","d","n","f","x","j","m","l","h","t","c","g","z","p","s"};
        }
        #endregion

        #region Funcões publicas
        public string Selecionar_Preposicoes_Klingon(string texto)
        {
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
                                resultado = resultado + palavra + "  ";
                                cont++;
                                break;
                            }
                        }
                    }
                }
            }
            // Adicionando quantidade
            return resultado + Environment.NewLine + separador + Environment.NewLine + " Total de Preposições => " + cont.ToString(); ;
        }
        public string Selecionar_Verbos_Klingon(string texto)
        {
            // Variaveis locais
            string Verbos = null;
            string VerbosPrimeiraPessoa = null;

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
                            cont++;
                            Verbos = Verbos + palavra + "  ";
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
                                VerbosPrimeiraPessoa = VerbosPrimeiraPessoa + palavra + "  ";
                                cont1++;
                                break;
                            }
                        }
                    }
                }
            }
            // Adicionando quantidade
            return Verbos + Environment.NewLine + separador + Environment.NewLine +
                  VerbosPrimeiraPessoa + Environment.NewLine + separador + Environment.NewLine +
                " Total de Verbos => " + cont.ToString() + Environment.NewLine +
                " Total de Verbos Na Primeira Pessoa => " + cont1.ToString();
        }
        public string Selcionar_Vocabulario_Klingon(string texto)
        {
            // Variaveis Local
            var alfabetoReferencia = new Dictionary<string, string>() {
                { " k " , " a " }, { " b " , " b " }, { " w " , " c " }, { " r " , " d " }, { " q " , " e " },
                { " d " , " f " }, { " n " , " g " }, { " f " , " h " }, { " x " , " i " }, { " j " , " j " },
                { " m " , " k " }, { " l " , " l " }, { " v " , " m " }, { " h " , " n " }, { " t " , " o " },
                { " c " , " p " }, { " g " , " q " }, { " z " , " r " }, { " p " , " s " }, { " s " , " t " }
            };
            novaPalavra = string.Empty;
            Dictionary<string, string> dicionario = new Dictionary<string, string>() { };

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
                    novaPalavra = novaPalavra + alfabetoReferencia.FirstOrDefault(x => x.Key == palavra.Substring(i, 1)).Value.ToString();
                }
                // Adiciona palavra traduzida
                dicionario.Add(palavra, novaPalavra);
            }

            // Ordena palavras klingon pela palavra traduzida
            var dicionarioOrdenado = dicionario.OrderBy(x => x.Value);

            // Percorre, palavras ordenadas klingon para resultado
            foreach (var palavra in dicionarioOrdenado)
            {
                resultado = resultado + palavra.Value + "  ";
            }
            return resultado;
        }
        public string Selecionar_Numeros_Bonitos_Klingon(string texto)
        {
            List<Int64> numerosPalavra = new List<long>();
            Dictionary<string, Int64> dicionario = new  Dictionary<string, Int64>() { };

            // Particionando texto Klingon
            textoParticionado = Particionar_Texto(texto);

            // Elimina palavras repetidas
            var textoPalavrasUnicas = (from n in textoParticionado select n ).Distinct();

            // Percorre palavras unicas
            foreach (var palavra in textoPalavrasUnicas )
            {
                novaPalavra = string.Empty;

                // Percorre letras da palavra
                for(int i = 0 ; i <= palavra.Length - 1; i++ )
                {
                    // Recuperando o numeo de localização das letras do alfabeto klingon
                    numerosPalavra.Add(Array.IndexOf(alfabetoKlingon, palavra.Substring(i, 1)));
                }

                ValorDaPalavra(numerosPalavra);



                // Adiciona palavra traduzida
                // dicionario.Add (palavra, novaPalavra);
            }




            return " ";
        }

        private Int64 ValorDaPalavra(List<long> numerosPalavra)
        {
            Int64 resultado = 0;
            for (int i = 0; i < numerosPalavra.Count; i++)
            {
                resultado = resultado + numerosPalavra[i] * 20 ^ numerosPalavra[i];
            }


            return resultado;
        }
        #endregion

        #region  Funcões privadas
        private string[] Particionar_Texto(string texto)
        {
            return texto.Split(new char[] { ' ' });
        }
        #endregion
    }
}
