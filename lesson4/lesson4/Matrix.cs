using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Matrix
    {
        private double[,] _Items;
        /// <summary>Число строк матрицы </summary>
        public int N
        {
            get { return _Items.GetLength(0); }
        }
        /// <summary>Число столбцов матрицы </summary>
        public int M
        {
            get { return _Items.GetLength(1); }
        }
        /// <summary> Является ли матрица квадтратной?</summary>
        public bool IsSquere
        {
            get { return N == M};
        }

        public double this[int n, int m]
        {
            get { return _Items[n, m]; }
            set { _Items[n, m] = value; }
        }

        /// <summary>Новая матрица </summary>
        /// <param name="N">Число строк</param>
        /// <param name="M">Число столбцов</param>
        public Matrix(int N, int M)
        {
            _Items = new double[N, M];
        }

        public static Matrix operator +(Matrix X, Matrix Y)
        {
            if (X == null) throw new ArgumentNullException(nameof(X));
            if (Y == null) throw new ArgumentNullException(nameof(Y));

            if (X.N != Y.N) throw new InvalidOperationException("Нельзя сложить две матрицы с разным числом строк");
            if (X.M != Y.M) throw new InvalidOperationException("Нельзя сложить две матрицы с разным числом столбцов");

            var result = new Matrix(X.N, X.M);

            for (int n = 0, N = X.N; n < N; n++)
                for (int m = 0, M = X.M; m < M; m++)
                    //result[n, m] = X[n, m] + Y[n, m];
                    result._Items[n, m] = X._Items[n, m] + Y._Items[n, m];
            return result;


        }
    }
}
