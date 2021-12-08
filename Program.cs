 using System;

namespace programe_cu_functii_si_tablouri
{
    class Program
    {
        static void Main(string[] args)
        {
            //prb1();
            //prb2();
            //prb3();
            //prb4();
            //prb5();
            //prb6();
            //prb7();
            //prb8();
            //prb9();
            //prb10();
            //prb11();
            //prb12();
            //prb13();
            //prb14();
            //prb15();
            //prb16();
            //prb17();
            //prb18();
            //prb19();
            //prb20();
            //prb21();
            //prb22();
            //prb23();
            //prb24();
            //prb25();
            //prb26();
            //prb27();
            //prb28();
            //prb29();
            //prb30();
            //prb31();
          

        }
        /// <summary>
        /// Se dau n, un număr natural și n numere întregi. Folosind un alt vector, să se aşeze numerele
        ///pare la început.
        /// </summary>
        private static void prb31()
        {
            int n, f = 0, a, c = 0,contor=1;
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];
            int[] v1 = new int[n + 1];
            for(int i=1;i<=n;i++)
            {
                a = int.Parse(Console.ReadLine());
                v[i] = a;
                if(a%2==0)
                {
                    c++;
                    f = 1;
                }
            }
            if(f==0)
            {
                Console.WriteLine("In vector nu exista valori pare");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (v[i] % 2 == 0)
                    {
                        v1[contor] = v[i];
                        contor++;
                    }
                    else
                    {
                        v1[n - c] = v[i];
                        c--;
                    }
                }
                Console.WriteLine("Elementele noului vector sunt:");
                for(int i=1;i<=n;i++)
                {
                    Console.Write($"{v1[i]} ");
                }
            }
            Console.ReadLine();

        }
        /// <summary>
        /// Să se extragă dintr-un vector elementele care au ultima cifră egală cu k şi să se formeze cu
        ///ele un alt vector.
        /// </summary>
        private static void prb30()
        {
            int n, a, cont = 1, f = 0, k;
            Console.WriteLine("Introduceti un n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un k:");
            k = int.Parse(Console.ReadLine());
            int[] v1 = new int[n + 1];
            int[] v2 = new int[n + 1];
            for (int j = 1; j <= n; j++)
            {
                a = int.Parse(Console.ReadLine());
                v1[j] = a;
                if (a % 10 == k)
                {
                    v2[cont] = a;
                    cont++;
                    f = 1;
                }
            }
            if (f == 1)
            {
                Console.WriteLine("Noul tablou arata in felul urmator:");
                for (int i = 1; i < cont; i++)
                {
                    Console.Write($"{v2[i]} ");
                }
            }
            else
            {
                Console.WriteLine("Nu exista numere care au ultima cifra egala cu k");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Se citesc de la tastatură n, un număr natural mai mic decât 100 și cele n elemente reale ale
        ///unui vector.Se cere să se insereze între oricare două elemente ale vectorului media lor
        ///aritmetică.
        /// </summary>
        private static void prb29()
        {
            int n, a,x;
            Console.WriteLine("Introduceti un n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[101];
            Random rnd = new Random();
            x = rnd.Next(1, n-1);
            for(int i=1;i<=n;i++)
            {
                a = int.Parse(Console.ReadLine());
                v[i] = a;
            }
            for(int i=n+1;i>x+1;i--)
            {
                v[i] = v[i - 1];
            }
            v[x + 1] = (v[x] + v[x + 2]) / 2;
            Console.WriteLine("Elementele vectorului conform cerintei sunt:");
            for(int i=1;i<=n+1;i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.ReadLine();


        }
        /// <summary>
        /// Se citesc de la tastatură un număr întreg x, k<=n<=1000, două numere naturale și n numere întregi.Inserați elementul x în vector pe poziția k.
        /// </summary>
        private static void prb28()
        {
            int n, k, a,x;
            Console.WriteLine("Introduceti un n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti o pozitie");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul pe care doriti sa il inserati");
            x = int.Parse(Console.ReadLine());
            int[] v = new int[1002];
            for(int i=1;i<=n+1;i++)
            {
                if(i==k)
                {
                    v[i] = x;
                }
                else
                {
                    a = int.Parse(Console.ReadLine());
                    v[i] = a;
                }
            }
            Console.WriteLine("Elementele vectorului dupa inserare sunt:");
            for(int i=1;i<=n+1;i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Se citesc de la tastatură k, un număr întreg, n<=1000, un număr natural și n numere întregi.
        ///Eliminați din vector toate elementele egale cu k
        /// </summary>
        private static void prb27()
        {
            int n, a, k, f = 0,cont=1;
            Console.WriteLine("Introduceti un n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un k:");
            k = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];
            for(int i=1;i<=n;i++)
            {
                a = int.Parse(Console.ReadLine());
                if(a!=k)
                {
                    v[cont] = a;
                    cont++;
                }
                else
                {
                    f++;
                }
            }
            if(f==n)
            {
                Console.WriteLine("In vector nu s au gasit elemente diferite de k");
            }
            else
            {
                Console.WriteLine("Eelmentele vectorului dupa eliminare sunt:");
                for(int i=1;i<cont;i++)
                {
                    Console.Write($"{v[i]} ");
                }
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Se citesc de la tastatură poz<=n<=1000, două numere naturale și n numere întregi. Eliminați din vector elementul aflat pe poziția poz.
        /// </summary>
        private static void prb26()
        {
            int n, a, poz;
            Console.WriteLine("Introduceti un n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti o pozitie:");
            poz = int.Parse(Console.ReadLine());
            int[] v = new int[1001];
            for (int i = 1; i <= n; i++)
            {
                a = int.Parse(Console.ReadLine());
                v[i] = a;
            }
            for(int i=poz+1;i<=n;i++)
            {
                v[i - 1] = v[i];
            }
            Console.WriteLine("Elementele vectorului dupa eliminare sunt:");
            for(int i=1;i<n;i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// . Se citesc de la tastatură k, un număr întreg, n<=1000, un număr natural și n numere întregi.Determinați poziția ultimului element din vector cu proprietatea că este egal cu k.
        /// </summary>
        private static void prb25()
        {
            int n, k, f = 0,a,aux=0;
            Console.WriteLine("Introduceti un n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un k:");
            k = int.Parse(Console.ReadLine());
            int[] v = new int[101];
            for(int i=1;i<=n;i++)
            {
                a = int.Parse(Console.ReadLine());
                v[i] = a;
            }
            for(int i=n;i>=1;i--)
            {
                if(v[i]==k)
                {
                    f = 1;
                    aux = i;
                    break;
                }
            }
            if(f==1)
            {
                Console.WriteLine($"Ultima poztie din vector cu proprietatea ceruta este {aux}");
            }
            else
            {
                Console.WriteLine("Nu s a gasit in vector un element care sa respecte cerinta");
            }
            Console.ReadLine();


        }
        /// <summary>
        /// Se citesc de la tastatură n<=100, un număr natural și n numere întregi. Determinați poziția primului element din vector cu proprietatea că este medie aritmetică între succesorul și predecesorul său.
        /// </summary>
        private static void prb24()
        {
            int n, a, j, k,f=0,aux=0;
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];
            for(int i=1;i<=n;i++)
            {
                a = int.Parse(Console.ReadLine());
                v[i] = a;
            }
            for(int i=2;i<n;i++)
            {
                j = i + 1;
                k = i - 1;
                if(v[i]==(v[j]+v[k])/2)
                {
                    f = 1;
                    aux = i;
                    break;
                }
            }
            if(f==1)
            {
                Console.WriteLine($"Prima pozitie cu proprietatea ceruta  din vector este {aux}");
            }
            else
            {
                Console.WriteLine("Nu s a gasit in vector proprietatea ceruta");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Să se construiască un vector v cu primii termeni ai şirului lui Fibonacci. 
        /// </summary>
        private static void prb23()
        {
            int n, f1 = 0, f2 = 1, f;
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];
            for(int i=1;i<=n;i++)
            {
                if(i==1)
                {
                    v[i] = f1;
                }
                else
                {
                    if(i==2)
                    {
                        v[i] = f2;
                    }
                    else
                    {
                        f = f1 + f2;
                        v[i] = f;
                        f1 = f2;
                        f2 = f;
                    }
                }
            }
            Console.WriteLine("Primii n termeni ai sirului lui Fibonacci sunt:");
            for(int i=1;i<=n;i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Fie X un vector cu n componente numere întregi. Să se calculeze expresia: e=x1-x2+x3-x4+….±xn.
        /// </summary>
        private static void prb22()
        {
            int n, a, e = 0;
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];
            for(int i=1;i<=n;i++)
            {
                a = int.Parse(Console.ReadLine());
                if(i%2==1)
                {
                    e += a;
                }
                else
                {
                    e -= a;
                }
            }
            Console.WriteLine($"Rezultatul expresiei este {e}");
            Console.ReadLine();
        }
        /// <summary>
        /// Functia care determina raportul dintre elem pare si elem impare dintr-un vector.
        /// </summary>
        private static void prb21()
        {
            Program rez = new Program();
            rez.raport();
        }
        public void raport()
        {
            int n, c1 = 0, c2 = 0, a;
            n = int.Parse(Console.ReadLine());
            int[] vect = new int[n + 1];
            for(int i=1;i<=n;i++)
            {
                a = int.Parse(Console.ReadLine());
                vect[i] = a;
                if(a%2==0)
                {
                    c1++;
                }
                else
                {
                    c2++;
                }
            }
            Console.WriteLine("Raportul dintre elementele pare si impare este:");
            Console.Write($"{c1}-pare si {c2}-impare,adica {c1 / c2}");
            Console.ReadLine();
        }
        /// <summary>
        /// Functia care determina daca un vector dat are numai elem pare.
        /// </summary>
        private static void prb20()
        {
            Program rez = new Program();
            rez.impare();
        }
        public void impare()
        {
            int n, a, f = 1;
            n = int.Parse(Console.ReadLine());
            int[] vect = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                a = int.Parse(Console.ReadLine());
                vect[i] = a;
                if (a % 2 != 0)
                {
                    f = 0;
                    break;
                }
            }
            if (f == 1)
            {
                Console.WriteLine("Vectorul are doar elemente pare");
            }
            else
            {
                Console.WriteLine("Vectorul nu are doar elemente pare");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Functia care determina daca un vector dat are numai elem impare.
        /// </summary>
        private static void prb19()
        {
            Program rez = new Program();
            rez.pare();
        }
        public void pare()
        {
            int n, a, f = 1;
            n = int.Parse(Console.ReadLine());
            int[] vect = new int[n + 1];
            for(int i=1;i<=n;i++)
            {
                a = int.Parse(Console.ReadLine());
                vect[i] = a;
                if(a%2!=1)
                {
                    f = 0;
                    break;
                }
            }
            if(f==1)
            {
                Console.WriteLine("Vectorul are doar elemente impare");
            }
            else
            {
                Console.WriteLine("Vectorul nu are doar elemente impare");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Functia care determina minimul unui vector dat
        /// </summary>
        private static void prb18()
        {
            Program rez = new Program();
            rez.minim();
        }
        public void minim()
        {
            int n, a, min = int.MaxValue;
            n = int.Parse(Console.ReadLine());
            int[] vect = new int[n + 1];
            for(int i=1;i<=n;i++)
            {
                a = int.Parse(Console.ReadLine());
                vect[i] = a;
                if(a<min)
                {
                    min = a;
                }
            }
            Console.WriteLine($"Minimul din vector este {min}");
            Console.ReadLine();
        }
        /// <summary>
        /// Functia care determina daca un vector dat e ordonat crescator.
        /// </summary>
        private static void prb17()
        {
            Program rez = new Program();
            rez.crescator();
        }
        public void crescator()
        {
            int n,f=1,a;
            n = int.Parse(Console.ReadLine());
            int[] vect = new int[n + 1];
            for(int i=1;i<=n;i++)
            {
                a = int.Parse(Console.ReadLine());
                vect[i] = a;
            }
            for(int i=1;i<n;i++)
            {
                if(vect[i]>vect[i+1])
                {
                    f = 0;
                    break;
                }
            }
            if(f==0)
            {
                Console.WriteLine("Vectorul nu este ordonat crescator");
            }
            else
            {
                Console.WriteLine("Vectorul este ordonat crescator");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Sa se scrie o functie care calculeaza media aritmetica a elementelor pare dintr-un vector de numere intregi.
        /// </summary>
        private static void prb16()
        {
            Program rez = new Program();
            rez.aritmetica();
        }
        public void aritmetica()
        {
            int n,a,cont=0,suma=0,f=0;
            n = int.Parse(Console.ReadLine());
            int[] vect = new int[n+1];
            for(int i=1;i<=n;i++)
            {
                a = int.Parse(Console.ReadLine());
                vect[i] = a;
            }
            for(int i=1;i<vect.Length;i++)
            {
                if(vect[i]%2==0)
                {
                    suma += vect[i];
                    f = 1;
                    cont++;
                }
            }
            if(f==1)
            {
                Console.WriteLine($"Media aritmetica a numerelor pare din vector este {suma / cont}");
            }
            else
            {
                Console.WriteLine("Nu sunt numere pare in vector");
            }
            Console.ReadLine();

        }
        /// <summary>
        /// Să se scrie un program care adună două matrici de dimensiune nxn.
        /// </summary>
        private static void prb15()
        {
            int n,a;
            n = int.Parse(Console.ReadLine());
            int[,] matrix1 = new int[n+1,n+1];
            int[,] matrix2 = new int[n+1,n+1];
            int[,] suma = new int[n+1,n+1];
            Console.WriteLine("Introduceti elementele primei matrici");
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    a = int.Parse(Console.ReadLine());
                    matrix1[i, j] = a;
                }
            }
            Console.WriteLine("Introduceti elementele matricei a doua");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    a = int.Parse(Console.ReadLine());
                    matrix2[i, j] = a;
                }
            }
            Console.WriteLine("Suma elementelor celor doua matrici este matricea:");
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    suma[i, j] = matrix1[i, j] + matrix2[i, j];
                    Console.Write($"{suma[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
        /// <summary>
        /// Să se scrie un program care memorează 100 de numere aleatoare cuprinse între 0 și 99 întrun tablou și care afișează numerele care se repetă în tablou.
        /// </summary>
        private static void prb14()
        {
            int x,f=0;
            Random rnd = new Random();
            int[] vect = new int[99];
            Console.WriteLine("Numerele care se repeta in tablou sunt:");
            for(int i=1;i<=100;i++)
            {
                x = rnd.Next(0, 99);
                vect[x]++;
                if(vect[x]>1 && vect[x]<3)
                {
                    f = 1;
                    Console.Write($"{x} ");
                }
            }
            if(f==0)
            {
                Console.Clear();
                Console.WriteLine("Nu sunt numere care se repeta in tablou");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Să se scrie o functie care primeste un număr și verifică dacă este palindrom sau nu.
        /// </summary>
        private static void prb13()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            Program rez = new Program();
            rez.palindrom(n);
        }
        public void palindrom(int n)
        {
            int aux, nr=0,cifr;
            aux = n;
            while(aux!=0)
            {
                cifr = aux % 10;
                nr = nr * 10 + cifr;
                aux = aux / 10;
            }
            if(nr==n)
            {
                Console.WriteLine("Numarul este palindrom");
            }
            else
            {
                Console.WriteLine("Numarul nu este palindorm");
            }
            Console.ReadLine();

        }
        /// <summary>
        ///  Să se scrie o funcție care inversează elementele memorate într-un tablou.
        /// </summary>
        private static void prb12()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            Program rez = new Program();
            rez.invers(n);
        }
        public void invers(int n)
        {
            int aux,a,cont=1,cifr=0,nr=0;
            int[] vect = new int[n + 1];
           
            for(int i=1;i<=n;i++)
            {
                a = int.Parse(Console.ReadLine());
                vect[cont] = a;
                cont++;
                
            }
            Console.WriteLine("Elementele initiale ale vectorului sunt:");
            for (int i = 1; i < vect.Length; i++)
            {
                    Console.Write($"{vect[i]} ");
            }
            for (int i=1;i<vect.Length;i++)
            {
                aux = vect[i];
                nr = 0;
                while(aux!=0)
                {
                    cifr = aux % 10;
                    nr = nr * 10 + cifr;
                    aux = aux / 10;
                }
                vect[i] = nr;
            }
            Console.WriteLine();
            Console.WriteLine($"Elementele vectorului dupa inversare sunt:");
            for(int i=1;i<vect.Length;i++)
            {
                Console.Write($"{vect[i]} ");
            }
            Console.ReadLine();

        }
        /// <summary>
        /// Să se scrie o functie pentru aflarea tablei inmulțirii unui număr utilizând bucla for și reprezentați-o în formatul corespunzător.
        /// </summary>
        private static void prb11()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            Program rez = new Program();
            rez.tabla(n);
        }
        public void tabla(int n)
        {
            Console.WriteLine($"Tabla inmultirii a numarului {n} este:");
            for(int i=1;i<=9;i++)
            {
                Console.WriteLine($"{i}*{n}={i * n}");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Să se scrie o funcție care calculează pătratul elementelor memorate într-un tablou. 
        /// </summary>
        private static void prb10()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            Program rez = new Program();
            rez.patrat(n);
        }
        public void patrat(int n)
        {
            int a,cont=1;
            int[] vect = new int[n+1];
            for(int i=1;i<=n;i++)
            {
                a = int.Parse(Console.ReadLine());
                vect[cont] = a;
                cont++;
            }
            Console.WriteLine("Patratele elementelor din vector sunt:");
            for(int i=1;i<vect.Length;i++)
            {
                Console.WriteLine($"{Math.Pow(vect[i], 2) }");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Scrieti o functie care să se verifice dacă un număr natural este sau nu cub perfect.
        /// </summary>
        private static void prb9()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            Program rez = new Program();
            rez.cub(n);
            
        }
        public void cub(int n)
        {
            double i;
            i = Math.Cbrt(n);
            if(Math.Pow(i,3)== n)
            {
                Console.WriteLine("Numarul este un cub perfect");
            }
            else
            {
                Console.WriteLine("Numarul nu este cub perfect");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Un muncitor lucrează n zile pentru a termina o lucrare. Scrieti o functie prin care sa se determine câte zile sunt necesare pentru a termina aceeaşi lucrare o echipă de mmuncitori.
        /// </summary>
        private static void prb8()
        {
            int n, m;
            Console.WriteLine("Introduceti numarul de zile si numarul de muncitori");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            Program rez = new Program();
            rez.zile(n, m);
        }
        public void zile(float n,float m)
        {
            float x, pf;
            x = n / m;
            pf = x-(int)x;
           if(pf>=0.5)
            {
                x = (int)x + 1;
            }
           else
            {
                x = (int)x;
            }
            Console.WriteLine($"Sunt necesare {x} zile pentru a termina o lucrare {m} muncitori");
            Console.ReadLine();


        }
        /// <summary>
        /// Viteza unui automobil este de v km/h. Scrieti o functie prin care sa exprimaţi această viteză în m/s.
        /// </summary>
        private static void prb7()
        {
            int v;
            v = int.Parse(Console.ReadLine());
            Program rez = new Program();
            rez.viteza(v);
        }
        public void viteza(int v)
        {
            Console.WriteLine($"Viteza din {v} km/h in m/s este {v / 3.6} m/s");
            Console.ReadLine();
        }
        /// <summary>
        /// Scrieţi o funcţie care să determine diferenţa dintre două momente de timp, date prin ore,minute şi secunde.
        /// </summary>
        private static void prb6()
        {
            Program rez = new Program();
            rez.diferenta();
        }
        public void diferenta()
        {
            int o1, o2, m1, m2, s1, s2,md=0,sd=0,od=0;
            Console.WriteLine("Introduceti ora,minutele si secundele primei date:");
            o1 = int.Parse(Console.ReadLine());
            m1 = int.Parse(Console.ReadLine());
            s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti ora,minutele si secundele datei a doua:");
            o2 = int.Parse(Console.ReadLine());
            m2 = int.Parse(Console.ReadLine());
            s2 = int.Parse(Console.ReadLine());
           if(o1==o2)
            {
                if(m1==m2)
                {
                    if(s1>s2)
                    {
                        sd = s1 - s2;
                    }
                    else
                    {
                        sd = s2 - s1;
                    }
                    md = m1 - m2;
                }
                else
                {
                    if(m1>m2)
                    {
                        if(s1<s2)
                        {
                            sd = s1 + 60 - s2;
                            m1--;
                        }
                        else
                        {
                            sd = s1 - s2;
                        }
                        md = m1 - m2;
                    }
                    else
                    {
                        if(m1<m2)
                        {
                            if(s1>s2)
                            {
                                sd = s2 + 60 - s1;
                                m2--;
                            }
                            else
                            {
                                sd = s2 - s1;
                            }
                            md = m2 - m1;
                        }
                    }

                }
                od = o1 - o2;
            }
           else
            {
                if(o1>o2)
                {
                    if(s1>=s2)
                    {
                        sd = s1 - s2;
                    }
                    else
                    {
                            sd = s1 + 60 - s2;
                            m1--;
                        
                    }
                    if(m1>=m2)
                    {
                        md = m1 - m2;
                    }
                    else
                    {
                        md = m1 + 60 - m2;
                        o1--;
                    }
                    od = o1 - o2;
                }
                else
                {
                    if(s1<=s2)
                    {
                        sd = s2 - s1;
                    }
                    else
                    {
                        sd = s2 + 60 - s1;
                        m2--;
                    }
                    if(m1<=m2)
                    {
                        md = m2 - m1;
                    }
                    else
                    {
                        md = m2 + 60 - m1;
                        o2--;
                    }
                    od = o2 - o1;
                }
            }
            Console.WriteLine("Diferenta dintre cele doua date este:");
            Console.Write($"{od} ore,{md} minute si {sd} secunde");
            Console.ReadLine();
        }
        /// <summary>
        /// Scrieţi o functie care să calculeze factorialul unui număr întreg n.
        /// </summary>
        private static void prb5()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            Program rez = new Program();
            rez.fact(n);
        }
        public void fact(int n)
        {
            int p = 1;
            for(int i=1;i<=n;i++)
            {
                p *= i;
            }
            Console.WriteLine($"Factorialul numarului {n} este {p}");
            Console.ReadLine();
        }
        /// <summary>
        /// Să se calculeze şi să se tipărească primii n termeni din şirul Fibonacci.
        /// </summary>
        private static void prb4()
        {
            int n,f1=0,f2=1,f;
            n = int.Parse(Console.ReadLine());
            if(n==1)
            {
                Console.WriteLine("Primul termen este 0");
            }
            else
            {
                if(n==2)
                {
                    Console.WriteLine("Primii doi termeni sunt 0 si 1");
                }
                else
                {
                    Console.Write($"Primii {n} termeni sunt:");
                    Console.Write($"{f1} {f2} ");
                    for(int i=3;i<=n;i++)
                    {
                        f = f1 + f2;
                        Console.Write($"{f} ");
                        f1 = f2;
                        f2 = f;
                    }
                }
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Scrie o metodă care primește ca parametru un număr natural x și apoi afișează:cifrele numarului(in ordine inversa) si suma cifrelor. 
        /// </summary>
        private static void prb3()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            Program rez = new Program();
            rez.nr(n);
        }
        public void nr(int x)
        {
            int aux,suma=0;
            Console.Write($"Cifrele numarului {x} in ordine inversa sunt:");
            aux = x;
            while(aux!=0)
            {
                Console.Write($"{aux % 10} ");
                suma += aux % 10;
                aux = aux / 10;
            }
            Console.WriteLine();
            Console.WriteLine($"Suma cifrelor numarului {x} este {suma}");
            Console.ReadLine();

        }
        /// <summary>
        /// Scrieti o functie cu numele putere care primeste prin parametrul n un numar natural cu cel mult 9 cifre si care furnizeaza prin parametrii x si k doua numere naturale cu proprietatea ca n = xk si x este minim.
        /// </summary>
        private static void prb2()
        {
            
        }
        /// <summary>
        /// Scrieţi o funcţie care să transforme un unghi exprimat în radiani în valoarea sa exprimată în grade şi una care să facă transformarea inversă.
        /// </summary>
        private static void prb1()
        {
            Console.WriteLine("Introduceti o valoare in radiani:");
            Program rez1 = new Program();
            rez1.radiani1();
            Console.WriteLine("Introduceti o valoare in grade:");
            Program rez2 = new Program();
            rez2.radiani2();
        }

        public void radiani1()
        {
            int r;
            r = int.Parse(Console.ReadLine());
            Console.WriteLine($"Valoarea in grade a {r} este {(r * 180) / Math.PI} grade");
            Console.ReadLine();

        }
        public void radiani2()
        {
            int grade;
            grade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Valoarea in radiani a {grade} este {(grade * Math.PI) / 180} radiani");
            Console.ReadLine();
        }
    }
}
