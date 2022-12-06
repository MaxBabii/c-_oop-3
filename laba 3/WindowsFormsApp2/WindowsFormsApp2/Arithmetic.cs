using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace New_class
{
    internal abstract class Class_base
    {
        protected int[] arr;
        private int num;
        private int step;

        protected Class_base(int value)
        {
            arr = new int [value];
        }
        public int Num
            { get { return num; } set { num = value; } }

        public virtual int Step
            { get { return step; } set { step = value; } }

        public int[] return_elements()
        {
            return arr;
        }
        public abstract int sum(int k);
        public abstract int k_elem(int k);
    }
    class Class_arifm : Class_base
    {
        public Class_arifm(int x): base(x) { }

        public override int Step { get => base.Step; set => base.Step = value; }

        public override int sum(int k)
        {
            return 0;
        }
        public override int k_elem(int k)
        {
            return 0;
        }
        private int next(int prev, int step)
        {
            return prev + step;
        }
        public void array_value()
        {
            arr[0] = Num;
            for(int i = 1; i < arr.Length; i++)
            {
                arr[i] = next(arr[i - 1], Step);
            }
        }
    }
}
