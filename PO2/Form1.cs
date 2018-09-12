using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;


namespace PO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //--Botão para Calcular------------------------------------------------------------------------------------
        private void calcular_Click(object sender, EventArgs e)
        {
            this.iteracoes.Rows.Clear();
            this.iteracoes_deriv.Rows.Clear();
            double valora, valorb, valordelta, valorerr;
            string func;

            valora = Convert.ToDouble(valor_a.Text);
            valorb = Convert.ToDouble(valor_b.Text);
            
            func = funcao.Text;
            
            //buscaUniforme.Checked? busca_uniforme(func, valora, valorb, valordelta):;

            if (buscaUniforme.Checked){
                valordelta = Convert.ToDouble(valor_delta.Text);
                busca_uniforme(func, valora, valorb, valordelta);
            }
            if (buscaDicotomica.Checked){
                valordelta = Convert.ToDouble(valor_delta.Text);
                valorerr = Convert.ToDouble(valor_err.Text);
                busca_dicotomica(func, valora, valorb, valordelta, valorerr);
            }
            if (metodoAurea.Checked){
                valorerr = Convert.ToDouble(valor_err.Text);
                secao_aurea(func, valora, valorb, valorerr);
            }
            if (buscaFibo.Checked){
                valorerr = Convert.ToDouble(valor_err.Text);
                busca_fibo(func, valora, valorb, valorerr);
            }
            if (metodoBisseccao.Checked){
                valorerr = Convert.ToDouble(valor_err.Text);
                bisseccao(func, valora, valorb, valorerr);
            }
            if (metodoNewton.Checked){
                valorerr = Convert.ToDouble(valor_err.Text);
                newton(func, valora, valorb, valorerr);
            }
            if (metodoCoorCiclic.Checked)
            {
                valorerr = Convert.ToDouble(valor_err.Text);
                coordenadas_ciclicas(func, valora, valorb, valorerr);
            }
        }
        //--Botão para Calcular--------------------------------------------------------------------------------------

        //--Métodos sem derivada------------------------------------------------------------------------------------       
        private void busca_uniforme(String func, double a, double b, double delta)
        {
            //------- Gera variáveis que serão utilizadas nas iterações
            int k = 0;
            double p, q,result_p,result_q;
            p = a;
            q = p + delta;
            bool delta_menor = false;
            //-- Gera a função com a variável para ser passada pro parser
            Argument x = new Argument("x", p);
            Expression exp_func = new Expression(func, x);
            //--Calcula pela busca uniforme
            do
            {
                result_p = exp_func.calculate(); //-- Resultado f(p)
                x.setArgumentValue(q);
                result_q = exp_func.calculate(); //-- Resultado f(q)
                imprime_datagrid(k, 0, 0, p, result_p, q, result_q);

                if(result_p < result_q && !delta_menor) //--Primeira parada antes de diminuir delta
                {
                    p -= delta;
                    delta /= 10;
                    q = p + delta;
                    x.setArgumentValue(p);
                    result_p = exp_func.calculate();
                    x.setArgumentValue(q);
                    result_q = exp_func.calculate();
                    delta_menor = true;
                }
                else
                {
                    if (result_p < result_q && delta_menor) //--Segunda parada depois do delta ser reduzido
                    {
                        resultado_deriv.Text = Convert.ToString(p);
                        return;
                    }
                    p = q;
                    q += delta;
                }
                k++;
            } while (k <= 300);
        }
        private void busca_dicotomica(String func, double a, double b, double delta, double err)
        {
            //------- Gera variáveis que serão utilizadas nas iterações
            int k = 0;
            double p = a, q, result_p, result_q,b_orig = b;
            //-- Gera a função com a variável para ser passada pro parser
            Argument x = new Argument("x", p);
            Expression exp_func = new Expression(func, x);
            //--Calcula por busca dicotomica
            do
            {
                p = ((a + b) / 2) - delta;//--Acha p
                q = ((a + b) / 2) + delta;//--Acha q
                x.setArgumentValue(p);
                result_p = exp_func.calculate();//-- Resultado f(p)
                x.setArgumentValue(q);
                result_q = exp_func.calculate();//-- Resultado f(q)
                imprime_datagrid(k, a, b, p, result_p, q, result_q);

                if(result_p < result_q) //--Escolher se a ou b que recebem p ou q
                {
                    b = q;
                }
                else
                {
                    a = p;
                }
                k++;
            } while ( Math.Abs(b-a) > err && b_orig >= b && k <= 300);
            imprime_datagrid(k, a, b, p, result_p, q, result_q);
            p = ((a + b) / 2);
            resultado_deriv.Text = Convert.ToString(p);
            return;
        }
        private void secao_aurea(String func, double a, double b, double err)
        {
            //------- Gera variáveis que serão utilizadas nas iterações
            int k = 0;
            double p = a, q, result_p, result_q, alpha = 0.61803, beta = 0.38197;
            //-- Gera a função com a variável para ser passada pro parser
            Argument x = new Argument("x", p);
            Expression exp_func = new Expression(func, x);
            //--Calcula por secção Aurea
            do
            {
                p = (a + beta * (b - a));//--Acha p
                q = (a + alpha *(b - a));//--Acha q
                x.setArgumentValue(p);
                result_p = exp_func.calculate();//-- Resultado f(p)
                x.setArgumentValue(q);
                result_q = exp_func.calculate();//-- Resultado f(q)
                imprime_datagrid(k, a, b, p, result_p, q, result_q);

                if (result_p < result_q) //--Escolher se a ou b que recebem p ou q
                {
                    b = q;
                }
                else
                {
                    a = p;
                }
                k++;
            } while (b - a > err && k <= 300);
            imprime_datagrid(k, a, b, p, result_p, q, result_q);
            p = ((a + b) / 2);
            resultado_deriv.Text = Convert.ToString(p);
            return;
        }
        private void busca_fibo(String func, double a, double b, double err)
        {
            //------------Criação lista fibonacci------------------------------------------
            List<double> fibo = new List<double>();
            fibo.Add(1.0);
            fibo.Add(1.0);
            double fibo_atual,fibo_alvo = ((b-a)/err);

            while( (fibo[fibo.Count - 1]) < fibo_alvo ){
                fibo_atual = fibo[fibo.Count - 1] + fibo[fibo.Count - 2];
                fibo.Add(fibo_atual);
            }
            //------------Criação lista fibonacci-------------------------------------------
            
            //------- Gera variáveis que serão utilizadas nas iterações
            int k = 0, f;
            double p = a, q, result_p, result_q;
            //-- Gera a função com a variável para ser passada pro parser

            Argument x = new Argument("x", p);
            Expression exp_func = new Expression(func, x);
            
            //--Calcula por fibonacci
            do
            {
                f = fibo.Count - 1;
                p = (a + (fibo[f-2-k]/fibo[f-k]) * (b - a)); //--Acha p
                q = (a + (fibo[f-1-k]/fibo[f-k]) * (b - a));//--Acha q
                x.setArgumentValue(p);
                result_p = exp_func.calculate();//--Resultado f(p)
                x.setArgumentValue(q);
                result_q = exp_func.calculate();//--Resultado f(q)
                imprime_datagrid(k, a, b, p, result_p, q, result_q);

                if (result_p < result_q) //--Escolher se a ou b que recebem p ou q
                {
                    b = q;
                }
                else
                {
                    a = p;
                }
                k++;
            } while ( (b - a > err) && fibo.Count - 3 > k);

            if (result_p < result_q) //--Escolher se a ou b que recebem p ou q
            {
                b = q;
            }
            else
            {
                a = p;
            }

            imprime_datagrid(k, a, b, p, result_p, q, result_q);
            p = ((a + b) / 2);
            resultado_deriv.Text = Convert.ToString(p);
            return;
        }
        //--Métodos sem derivada------------------------------------------------------------------------------------       

        //--Métodos com derivada-------------------------------------------------------------------------------------
        private void bisseccao(String func, double a, double b, double err)
        {
            //------- Gera variáveis que serão utilizadas nas iterações
            int k = 0;
            double x = ((b + a)/ 2), result_x1;
            //-- Gera a função com a variável para ser passada pro parser
            Argument y = new Argument("x", x);
            Expression exp_func = new Expression(func, y);
            Expression exp_func_der = new Expression("der("+func+", x)", y);

            result_x1 = exp_func_der.calculate(); //Valor da derivada f'(x)

            imprime_datagrid_deriv(k, a, b, x, result_x1, 0.0);
            //---------------------------------------------------
            while (result_x1 != 0 && Math.Abs(b-a) > err)
            {
                x = ((a + b) / 2);
                y.setArgumentValue(x);
                result_x1 = exp_func_der.calculate();
                if (result_x1 > 0)
                {
                    b = x;
                }
                if(result_x1 < 0)
                {
                    a = x;
                }
                k++;
                imprime_datagrid_deriv(k, a, b, x, result_x1, 0.0);
            }
            x = ((a + b) / 2);
            y.setArgumentValue(x);
            //--------------------------------------------------------------
            k++;
            imprime_datagrid_deriv(k, a, b, x, result_x1, 0.0);
            label12.Text = Convert.ToString(x);
        }
        private void newton(String func, double a, double b, double err)
        {
            //------- Gera variáveis que serão utilizadas nas iterações
            int k = 0;
            double xk = a, xk_1 = 0, result_x1, result_x2, erro = 0, modulo_resultx1;
            //-- Gera a função com a variável para ser passada pro parser

            Argument y = new Argument("x", xk);
            Expression exp_func = new Expression(func, y);
            Expression exp_func_der = new Expression("der(" + func + ", x)", y);
            Expression exp_func_der_segunda = new Expression("der((der(" + func + ", x)),x)", y);

            result_x1 = exp_func_der.calculate();
            result_x2 = exp_func_der_segunda.calculate();
            modulo_resultx1 = Math.Abs(result_x1);

            imprime_datagrid_deriv(k, a, b, xk, result_x1, result_x2,erro);
            //-----------------------------------------------------------------------------------
            do
            {
                xk_1 = xk - (result_x1 / result_x2);
                
                y.setArgumentValue(xk_1);
                result_x1 = exp_func_der.calculate();
                result_x2 = exp_func_der_segunda.calculate();

                modulo_resultx1 = Math.Abs(result_x1);

                k++;
                
                erro = Math.Abs(xk - xk_1);
                imprime_datagrid_deriv(k, a, b, xk_1, result_x1, result_x2,erro);

                xk = xk_1;
                //label12.Text = Convert.ToString(erro);
            } while (erro > err && k < 300 && modulo_resultx1 > err);
            //-----------------------------------------------------------------------------------
            k++;
            imprime_datagrid_deriv(k, a, b, xk_1, result_x1, result_x2,erro);
            label12.Text = Convert.ToString(xk_1);

        }
        private double minnewton(String func, double a, double err)
        {
            //------- Gera variáveis que serão utilizadas nas iterações
            int k = 0;
            double xk = a, xk_1 = 0, result_x1, result_x2, erro = 0, modulo_resultx1;
            //-- Gera a função com a variável para ser passada pro parser

            Argument y = new Argument("x", xk);
            Expression exp_func = new Expression(func, y);
            Expression exp_func_der = new Expression("der(" + func + ", x)", y);
            Expression exp_func_der_segunda = new Expression("der((der(" + func + ", x)),x)", y);

            result_x1 = exp_func_der.calculate();
            result_x2 = exp_func_der_segunda.calculate();
            modulo_resultx1 = Math.Abs(result_x1);

            //-----------------------------------------------------------------------------------
            do
            {
                xk_1 = xk - (result_x1 / result_x2);

                y.setArgumentValue(xk_1);
                result_x1 = exp_func_der.calculate();
                result_x2 = exp_func_der_segunda.calculate();

                modulo_resultx1 = Math.Abs(result_x1);

                k++;

                erro = Math.Abs(xk - xk_1);
                
                xk = xk_1;
                //label12.Text = Convert.ToString(erro);
            } while (erro > err && k < 300 && modulo_resultx1 > err);
            //-----------------------------------------------------------------------------------
            k++;
            return xk_1;
        }
        //--Métodos com derivada------------------------------------------------------------------------------------

        //--Métodos multivariável sem restrições com derivada------------------------------------------------------------------------
        private void coordenadas_ciclicas(String func, double x1, double x2, double err)
        {
            //------- Gera variáveis que serão utilizadas nas iterações
            int k = 0, power = 2;
            double xk_1 = x1, xk_2 = x2,xk1_1 = xk_1, xk1_2 = xk_2, lambda1, lambda2, yk_1 = x1, yk_2 = x2, yk1_1 = yk_1, yk1_2 = yk_2, erro;
            //-- Gera a função com a variável para ser passada pro parser
            Argument x = new Argument("x1", x1);
            Argument y = new Argument("x2", x2);
            Function f = new Function("f", func, "x1","x2");
            Expression exp_func_lambda1 = new Expression("f("+Convert.ToString(yk_1)+"+x*1,"+Convert.ToString(yk_2)+"+x*0)");
            exp_func_lambda1.addFunctions(f);
            Expression exp_func_lambda2 = new Expression("f("+Convert.ToString(yk_1)+"+x*0,"+Convert.ToString(yk_2)+"+x*1)");
            exp_func_lambda2.addFunctions(f);

            //do
            //{
                if (k>0)
                {
                    yk_1 = yk1_1;
                    yk_2 = yk1_2;
                    xk_1 = xk1_1;
                    xk_2 = xk1_2;
                }
                yk_1 = xk_1;
                yk_2 = xk_2;
                lambda1 = exp_func_lambda1.calculate();
                lambda2 = exp_func_lambda2.calculate();
                label16.Text = "(" + Convert.ToString(lambda1) + "," + Convert.ToString(lambda2) + ")";
                yk1_1 = yk_1 + lambda1;
                yk1_2 = yk_2 + lambda2;
                xk1_1 = yk1_1;
                xk1_2 = yk1_2;
                if (k == 0)
                {
                    erro = 1;
                }
                else
                {
                    erro = Math.Sqrt( (Math.Pow(xk1_1 - xk_1, power)) + (Math.Pow(xk1_2 - xk_2, power)) );
                }
                k++;
            //} while (erro > err && k<300);

            //label16.Text = "("+Convert.ToString(xk1_1)+","+Convert.ToString(xk1_2) + ")";
        }
        //--Métodos multivariável sem restrições com derivada------------------------------------------------------------------------

        //--Método de derivada------------------------------------------------------------------------------------
        //private double derivada(String func, double xk)
        //{
        //    double delta_x = 0.1, result_mais, result_menos, result;

        //    Argument x = new Argument("x", 0);
        //    Expression exp_func = new Expression(func, x);
        //    do
        //    {
        //        x.setArgumentValue(xk + delta_x);
        //        result_mais = exp_func.calculate();
        //        x.setArgumentValue(xk - delta_x);
        //        result_menos = exp_func.calculate();

        //        result = ((result_mais - result_menos) / (delta_x * 2));

        //        delta_x *= 0.1;
        //    } while (delta_x >= 0.000001 && delta_x < -0.000001);
        //    return result;
        //}
        //--Método de derivada------------------------------------------------------------------------------------

        //--Exemplos-----------------------------------------------------------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            //--Carrega exemplos nos valores ----

            //int selectedIndex = exemplos.SelectedIndex;
            //Object selectedItem = exemplos.SelectedItem;

            //MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n" +
            //                "Index: " + selectedIndex.ToString());

            Object selectedItem = exemplos.SelectedItem;
            funcao.Text = selectedItem.ToString();
            valor_a.Text = ex_a.Text;
            valor_b.Text = ex_b.Text;
            valor_delta.Text = ex_delta.Text;
            valor_err.Text = ex_err.Text;
        }
        private void exemplos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //--Carrega exemplos nas labels----
            int index = exemplos.SelectedIndex;
            button1.Enabled = true;
            switch (index)
            {
                case 0:
                    ex_a.Text = "-1";
                    ex_b.Text = "2";
                    ex_delta.Text = "0,5";
                    ex_err.Text = "0,8";
                    break;
                case 1:
                    ex_a.Text = "-3";
                    ex_b.Text = "5";
                    ex_delta.Text = "0,5";
                    ex_err.Text = "0,8";
                    break;
                case 2:
                    ex_a.Text = "-1";
                    ex_b.Text = "2";
                    ex_delta.Text = "0,01";
                    ex_err.Text = "0,1";
                    break;
                case 3:
                    ex_a.Text = "-4";
                    ex_b.Text = "4";
                    ex_delta.Text = "0,0";
                    ex_err.Text = "0,001";
                    break;
                case 4:
                    ex_a.Text = "-3";
                    ex_b.Text = "6";
                    ex_delta.Text = "0,01";
                    ex_err.Text = "0,01";
                    break;
            }
        }
        //--Exemplos-----------------------------------------------------------------------------------------------------------------------------------

        //--Imprime no DataGrid-------------------------------------------------------------------------------
        private void imprime_datagrid(int k, double a, double b, double p, double result_p, double q, double result_q)
        {
            //Imprime a linha, em todas as colunas da tabela
            this.iteracoes.Rows.Add();
            this.iteracoes.Rows[k].Cells[0].Value = k + 1;
            this.iteracoes.Rows[k].Cells[1].Value = a;
            this.iteracoes.Rows[k].Cells[2].Value = b;
            this.iteracoes.Rows[k].Cells[3].Value = p;
            this.iteracoes.Rows[k].Cells[4].Value = result_p;
            this.iteracoes.Rows[k].Cells[5].Value = q;
            this.iteracoes.Rows[k].Cells[6].Value = result_q;
            this.iteracoes.Rows[k].Cells[7].Value = (b - a);
        }
        private void imprime_datagrid_deriv(int k, double a, double b, double x, double result_x1, double result_x2)
        {
            //Imprime a linha, em todas as colunas da tabela
            this.iteracoes_deriv.Rows.Add();
            this.iteracoes_deriv.Rows[k].Cells[0].Value = k + 1;
            this.iteracoes_deriv.Rows[k].Cells[1].Value = a;
            this.iteracoes_deriv.Rows[k].Cells[2].Value = b;
            this.iteracoes_deriv.Rows[k].Cells[3].Value = x;
            this.iteracoes_deriv.Rows[k].Cells[4].Value = result_x1;
            this.iteracoes_deriv.Rows[k].Cells[5].Value = result_x2;
            this.iteracoes_deriv.Rows[k].Cells[6].Value = (b - a);
        }
        private void imprime_datagrid_deriv(int k, double a, double b, double x, double result_x1, double result_x2, double err)
        {
            //Imprime a linha, em todas as colunas da tabela
            this.iteracoes_deriv.Rows.Add();
            this.iteracoes_deriv.Rows[k].Cells[0].Value = k + 1;
            this.iteracoes_deriv.Rows[k].Cells[1].Value = a;
            this.iteracoes_deriv.Rows[k].Cells[2].Value = b;
            this.iteracoes_deriv.Rows[k].Cells[3].Value = x;
            this.iteracoes_deriv.Rows[k].Cells[4].Value = result_x1;
            this.iteracoes_deriv.Rows[k].Cells[5].Value = result_x2;
            this.iteracoes_deriv.Rows[k].Cells[6].Value = err;
        }
        //--Imprime no DataGrid-------------------------------------------------------------------------------

        //--Habilitar e desabilitar de acordo com RadioButton--------------------------
        private void buscaUniforme_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "a:";
            label3.Text = "b:";
            label5.Text = "Δ:";
            tabControl1.SelectedIndex = 0;
            valor_delta.Enabled = true;
            valor_err.Enabled = false;
            valor_M0.Enabled = false;
        }
        private void buscaDicotomica_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "a:";
            label3.Text = "b:";
            label5.Text = "Δ:";
            tabControl1.SelectedIndex = 0;
            valor_delta.Enabled = true;
            valor_err.Enabled = true;
            valor_M0.Enabled = false;
        }
        private void metodoAurea_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "a:";
            label3.Text = "b:";
            label5.Text = "Δ:";
            tabControl1.SelectedIndex = 0;
            valor_delta.Enabled = false;
            valor_err.Enabled = true;
            valor_M0.Enabled = false;
        }
        private void buscaFibo_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "a:";
            label3.Text = "b:";
            label5.Text = "Δ:";
            tabControl1.SelectedIndex = 0;
            valor_delta.Enabled = false;
            valor_err.Enabled = true;
            valor_M0.Enabled = false;
        }

        
        private void metodoNewton_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "a:";
            label3.Text = "b:";
            label5.Text = "Δ:";
            tabControl1.SelectedIndex = 1;
            valor_delta.Enabled = false;
            valor_err.Enabled = true;
            valor_M0.Enabled = false;
        }
        private void metodoBisseccao_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "a:";
            label3.Text = "b:";
            label5.Text = "Δ:";
            tabControl1.SelectedIndex = 1;
            valor_delta.Enabled = false;
            valor_err.Enabled = true;
            valor_M0.Enabled = false;
        }


        private void metodoCoorCiclic_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "x1:";
            label3.Text = "x2:";
            label5.Text = "β:";
            tabControl1.SelectedIndex = 2;
            valor_delta.Enabled = false;
            valor_err.Enabled = true;
            valor_M0.Enabled = false;
        }


        private void metodoNewtonSemRest_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "x1:";
            label3.Text = "x2:";
            label5.Text = "β:";
            tabControl1.SelectedIndex = 3;
            valor_delta.Enabled = false;
            valor_err.Enabled = true;
            valor_M0.Enabled = false;
        }
        //--Habilitar e desabilitar de acordo com RadioButton--------------------------

        private void resultados_Enter(object sender, EventArgs e) {}
        private void panel1_Paint(object sender, PaintEventArgs e) {}
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {}
        private void Form1_Load(object sender, EventArgs e){}
        private void radioButton2_CheckedChanged(object sender, EventArgs e){}
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}
        private void label16_Click(object sender, EventArgs e){}
        private void label17_Click(object sender, EventArgs e){}

    }
}
