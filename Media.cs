using System;

namespace pjrCalculadora
{
    public class Media : Operacao
    {
        public string calcularMedia(string[] mediaNumeros){
            float result = 0;
            int tamanho = mediaNumeros.Length, i = 0;
            float[] numeros = new float[tamanho+1];
            foreach (var item in mediaNumeros)
            {
                numeros[i] = float.Parse(item);
                i++;
            }
            for(i = 0; i <= tamanho; i++){
                result = result + numeros[i];
            }
            resultado = result/tamanho;
            return $"\nMédia: {resultado}";
        }
    }
}