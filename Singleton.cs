using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_PIX
{
    internal class Singleton
    {
        private static Singleton? _instance;
        private static readonly object threadLock = new();

        public static Singleton Instance
        {
            get
            {
                if (_instance == null) // nao inicializado
                    lock (threadLock) // token de sincronizacao - exclusivo primeira execucao/thread
                        _instance ??= new Singleton(); // inicializado `if == null`
                return _instance;
            }
        }

        public static FrmMain FrmMain = new();
    }
}
