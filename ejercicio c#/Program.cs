// See https://aka.ms/new-console-template for more information


namespace HelloWorld
{

    class program
    {

        static void Main(string[] args){
            while (true){
                Console.WriteLine("Digite el número del ejercicio que desea revisar: ");
                int ejercicio = Convert.ToInt32(Console.ReadLine());
                switch (ejercicio)
                {
                    case 1:
                        Console.WriteLine(SistemaBodega());
                        break;
                    case 2:
                        Console.WriteLine(SistemaBodega2());
                        break;
                    case 3:
                        Console.WriteLine(SistemaBodega3());
                        break;
                    case 4:
                        Console.WriteLine(SistemaBodega4());
                        break;
                    case 5:
                        Console.WriteLine(descuentosEmpresa());
                        break;
                    case 6:
                        Console.WriteLine(sistemaFacturacionCiclo());
                        break;
                    case 7:
                    Console.WriteLine(sistemaFacturacionComplejo());
                        break;
                }
            }
        }

        static string SistemaBodega(){
            Console.WriteLine("Sistema de inventario");
            Console.WriteLine("Digite la cantidad de stock de producto en el inventario: ");
            int CantidadStockProducto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite la cantidad mínima requerida del producto: ");
            int CantidadMinimaRequerida = Convert.ToInt32(Console.ReadLine());
            string ResultadoSaldo;
            int SaldoCantidadProducto = CantidadStockProducto - CantidadMinimaRequerida;
            if(SaldoCantidadProducto>= 0){
                ResultadoSaldo = "No es necesaria la compra de más stock de este producto, la cantidad de stock sobrante es: "+Convert.ToString(SaldoCantidadProducto);
            }
            else
            {
                ResultadoSaldo = "Es necesaria la compra de más stock de este producto, cantidad de stock a comprar es: "+Convert.ToString(SaldoCantidadProducto*-1);
            };

            return ResultadoSaldo;
        }

        static string SistemaBodega2(){
            Console.WriteLine("Sistema de inventario");
            Console.WriteLine("Digite la cantidad de stock de producto en el inventario: ");
            int CantidadStockProducto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite la cantidad mínima requerida del producto: ");
            int CantidadMinimaRequerida = Convert.ToInt32(Console.ReadLine());
            string ResultadoSaldo;
            int SaldoCantidadProducto = CantidadStockProducto - CantidadMinimaRequerida;
            if(SaldoCantidadProducto > 0){
                ResultadoSaldo = "No es necesaria la compra de más stock de este producto, la cantidad de stock sobrante es: "+Convert.ToString(SaldoCantidadProducto);
            }
            else if(SaldoCantidadProducto < 0)
            {
                ResultadoSaldo = "Es necesaria la compra de más stock de este producto, cantidad de stock a comprar es: "+Convert.ToString(SaldoCantidadProducto*-1);
            }
            else
            {
                ResultadoSaldo = "Es necesaria la compra de más stock de este producto al proveedor, no quedarán unidades en bodega";
            };

            return ResultadoSaldo;
        }

        static string SistemaBodega3(){
            Console.WriteLine("Sistema de inventario");
            Console.WriteLine("Digite la cantidad de stock de producto en el inventario: ");
            int CantidadStockProducto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite la cantidad mínima requerida del producto: ");
            int CantidadMinimaRequerida = Convert.ToInt32(Console.ReadLine());
            string ResultadoSaldo;
            string Alerta = " ";
            int SaldoCantidadProducto = CantidadStockProducto - CantidadMinimaRequerida;

            if(CantidadStockProducto <= 10){
                Alerta = "!!! La cantidad de unidades en stock es menor a 10!!! por favor acuda al proveedor para reponer unidades, unidades sobrantes: "+Convert.ToString(CantidadStockProducto) +"\n";
            }

            if(SaldoCantidadProducto > 0){
                ResultadoSaldo = Alerta+"No es necesaria la compra de más stock de este producto, la cantidad de stock antes de reponer es: "+Convert.ToString(SaldoCantidadProducto);
            }
            else if(SaldoCantidadProducto < 0)
            {
                ResultadoSaldo = Alerta+"Es necesaria la compra de más stock de este producto, cantidad de stock a comprar es: "+Convert.ToString(SaldoCantidadProducto*-1);
            }
            else
            {
                ResultadoSaldo = Alerta+"Es necesaria la compra de más stock de este producto al proveedor, no quedan unidades en bodega";
            };

            return ResultadoSaldo;
        }

        static string SistemaBodega4(){
            Console.WriteLine("Sistema de inventario");
            Console.WriteLine("Digite la cantidad de stock de producto en el inventario: ");
            int CantidadStockProducto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite la cantidad mínima requerida del producto: ");
            int CantidadMinimaRequerida = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de dinero disponible en caja: ");
            int ValorEnCaja = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el valor unitario del producto: ");
            int ValorProducto = Convert.ToInt32(Console.ReadLine());
            string ResultadoSaldo;
            string Alerta = " ";
            int SaldoCantidadProducto = CantidadStockProducto - CantidadMinimaRequerida;

            if(CantidadStockProducto <= 10){
                Alerta = "!!! La cantidad de unidades en stock es menor a 10¡¡¡ por favor acuda al proveedor para reponer unidades, unidades sobrantes: "+Convert.ToString(CantidadStockProducto) +"\n";
            }

            if(SaldoCantidadProducto > 0){
                ResultadoSaldo = Alerta+"No es necesaria la compra de más stock de este producto, la cantidad de stock antes de reponer es: "+Convert.ToString(SaldoCantidadProducto);

            }
            else if(SaldoCantidadProducto < 0)
            {
                ResultadoSaldo = Alerta+"Es necesaria la compra de más stock de este producto, cantidad de stock a comprar es: "+Convert.ToString(SaldoCantidadProducto*-1);
                if((ValorProducto)*(SaldoCantidadProducto*-1)<=ValorEnCaja){
                    if(SaldoCantidadProducto<0){
                        ResultadoSaldo = ResultadoSaldo +"\n el valor en caja es suficiente para la compra del stock faltante, valor en caja: "+ ValorEnCaja +", valor unidad producto: "+ (ValorProducto) +", cantidad necesaria: "+ (SaldoCantidadProducto*-1) +", valor compra: " + (ValorProducto*(SaldoCantidadProducto*-1));
                    }
                    else{
                        ResultadoSaldo = ResultadoSaldo +"\n el valor en caja es suficiente para la compra del stock faltante, valor en caja: "+ ValorEnCaja +", valor unidad producto: "+ (ValorProducto) +", cantidad necesaria: "+ SaldoCantidadProducto +", valor compra: " + (ValorProducto*(SaldoCantidadProducto*-1));
                    }
                }
                else{
                    ResultadoSaldo = ResultadoSaldo + "\n El valor en caja no es suficiente para la compra del stock faltante, valor en caja: "+ ValorEnCaja +", valor unidad producto: "+ (ValorProducto) +", cantidad necesaria: "+ (SaldoCantidadProducto*-1) +", valor compra: " + (ValorProducto*(SaldoCantidadProducto*-1));
                };
            }
            else
            {
                ResultadoSaldo = Alerta+"Es necesaria la compra de más stock de este producto al proveedor, no quedan unidades en bodega";
            };

            return ResultadoSaldo;
        }

        static string descuentosEmpresa(){
            Console.WriteLine("Sistema de Descuentos empresa");
            Console.WriteLine("Digite el número de día de la semana en que se encuentra, ejemplo: lunes= 1, martes= 2...    :");
            int numeroDiaSemana = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el valor total de su compra aún sin el descuento:");
            int totalPago = Convert.ToInt32(Console.ReadLine());
            string valorPagoConDescuento; 
            switch (numeroDiaSemana)
            {
                case 1:
                valorPagoConDescuento = Convert.ToString(totalPago*0.95);
                    break;
                case 2:
                valorPagoConDescuento = Convert.ToString(totalPago*0.97);
                    break;
                case 3:
                valorPagoConDescuento = Convert.ToString(totalPago*0.90);
                    break;
                case 4:
                valorPagoConDescuento = Convert.ToString(totalPago*0.96);
                    break;
                case 5:
                valorPagoConDescuento = Convert.ToString(totalPago*0.94);
                    break;
                case 6:
                valorPagoConDescuento = Convert.ToString(totalPago*0.98);
                    break;
                case 7:
                valorPagoConDescuento = Convert.ToString(totalPago*0.99);
                    break;
                default:
                valorPagoConDescuento = "Error, digite un día de la semana válido";
                    break;
            }
            return valorPagoConDescuento;
        }

        static string sistemaFacturacionCiclo(){
            Console.WriteLine("Digite la cantidad de productos que va a comprar: ");
            int cantidadProductos = Convert.ToInt32(Console.ReadLine());
            List<int> Carrito = new List<int>();
            int valorTotal = 0;
            string resultadoCompra = "el valor total de los "+cantidadProductos+ " es: ";

            for (int i = 1; i <= cantidadProductos; i++)
            {
                Console.WriteLine("Digite la cantida de unidades del producto "+i+" que desea comprar: ");
                int cantidadProducto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite el valor por unidad del producto que desea comprar: ");
                int valorUnidad = Convert.ToInt32(Console.ReadLine());
                int valorPago = cantidadProducto*valorUnidad;
                Carrito.Add(valorPago);
                Console.WriteLine("Cantidad del producto "+i+" es: "+cantidadProducto+" y su valor unitario es: "+valorUnidad);
            }

            foreach (var item in Carrito)
            {
                valorTotal += item;
            }
            return resultadoCompra+valorTotal;
        }
    
        static string sistemaFacturacionComplejo(){

            List<double> totalPagoClientes = new List<double>();
            double valorCompraClientes = 0;
            int pararCiclo = 1;
            string resultadoCompraTodosLosClientes = "el valor total de las compras de hoy es: ";

            
            while (pararCiclo == 1)
            {
                Console.WriteLine("Digite la cantida de productos que desea comprar: ");
                int cantidadProductos = Convert.ToInt32(Console.ReadLine());
                List<int> Carrito = new List<int>();
                double valorTotal = 0;
                string resultadoCompra = "el valor total de los "+cantidadProductos+ " es: ";

                for (int i = 1; i <= cantidadProductos; i++)
                {
                    Console.WriteLine("Digite la cantida de unidades del producto "+i+" que desea comprar: ");
                    int cantidadProducto = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite el valor por unidad del producto que desea comprar: ");
                    int valorUnidad = Convert.ToInt32(Console.ReadLine());
                    int valorPago = cantidadProducto*valorUnidad;
                    Console.WriteLine("Cantidad del producto "+i+" es: "+cantidadProducto+" y su valor unitario es: "+valorUnidad);
                    Carrito.Add(valorPago);
                }

                foreach (var item in Carrito)
                {
                    valorTotal += item;
                }

                if(valorTotal > 100000){
                    valorTotal = valorTotal*0.90;
                }

                totalPagoClientes.Add(valorTotal);
                Console.WriteLine("¿Desea parar el sistema? 1 = No, 2 = Sí");
                pararCiclo = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var item in totalPagoClientes)
                {
                    valorCompraClientes+= item;
                }

            return resultadoCompraTodosLosClientes+valorCompraClientes;
        }

    }

}
