using System;

class Nacional : Veiculo {

 protected virtual void definirValorVeiculo(double CustoFixo){
   double Calcvalor = CustoFixo*1.5+0.2*CustoFixo/10;
  }
} 