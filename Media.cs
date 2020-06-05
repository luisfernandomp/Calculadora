using System;
namespace pjrCalculadora
{
    public class Media : Operacao
    {
        public string calcularMedia(string[] mediaNumeros){
            float result = 0;
            for(int i = 0; i <= mediaNumeros.Length; i++){
                result = result + float.Parse(mediaNumeros[i]);
            }
            resultado = result/mediaNumeros.Length;
            return $"Média: {resultado}";
        }
    }
}