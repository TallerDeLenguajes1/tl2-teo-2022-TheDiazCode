namespace Cuenta;

public class CCPesos : CuentaBancaria{

    //constructor
    public CCPesos(){

    }
    //metodos
    public override void Insercion(int monto){
        
    }

    public override void Extraccion(int monto, TipoExtraccion tipo){
        if(balance > -5000 & (balance - monto) >-5000){
            if(TipoExtraccion.CajeroAutomatico == tipo & monto < 20000){
                balance -= monto;
            }else{
                balance -= monto;
            }
            Console.WriteLine("balance actual es ${0}",balance);
        }else{
            Console.WriteLine("no tiene fondos suficientes");
        }
    }
}