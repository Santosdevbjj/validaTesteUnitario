--- /dev/null
+++ src/ValidacoesConsole/ValidacoesString.cs
@@ -0,0 +1,43 @@
using System;

namespace ValidacoesConsole
{
    public class ValidacoesString
    {
        public int RetornarQuantidadeCaracteres(string texto)
        {
            if (texto == null)
                throw new ArgumentNullException(nameof(texto));
            return texto.Length;
        }

        public bool ContemCaractere(string texto, string trecho)
        {
            if (texto == null)
                throw new ArgumentNullException(nameof(texto));
            if (trecho == null)
                throw new ArgumentNullException(nameof(trecho));
            return texto.Contains(trecho);
        }

        public bool TextoTerminaCom(string texto, string trecho)
        {
            if (texto == null)
                throw new ArgumentNullException(nameof(texto));
            if (trecho == null)
                throw new ArgumentNullException(nameof(trecho));
            return texto.EndsWith(trecho);
        }
    }
}
