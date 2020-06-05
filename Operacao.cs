using System;

namespace pjrCalculadora
{
    public class Operacao
    {
        public float num1 { get; set; }
        public float num2 { get; set; }
        public string simbolo { get; set; }
        protected float resultado { get; set; }
        public string calculadora(string[] operar){
            bool teste = false;
            string result = "";
            foreach (var item in operar)
            {
                if(item == "+" || item == "-" || item == "/" || item == "*"){
                    teste = true;
                }
            }
            if(teste == true){
                num1 = float.Parse(operar[0]);
                simbolo = operar[1];
                num2 = float.Parse(operar[2]);
                if(simbolo == "+"){
                    resultado = num1 + num2;
                    return $"\n{num1} {simbolo} {num2} = {resultado}";
                }else{
                    if(simbolo == "-"){
                        resultado = num1 - num2;
                        return $"\n{num1} {simbolo} {num2} = {resultado}";
                    }else{
                        if(simbolo == "*"){
                            resultado = num1 * num2;
                            return $"\n{num1} {simbolo} {num2} = {resultado}";
                        }else{
                            if(simbolo == "/"){
                                resultado = num1 / num2;
                                return $"\n{num1} {simbolo} {num2} = {resultado}";
                            }else{
                                return "Operação inválida!";
                            }
                        }
                    }
                }
            }else{
                Media md = new Media();
                result = md.calcularMedia(operar);
                return result;
            }
        }
    }
}