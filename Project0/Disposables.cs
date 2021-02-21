using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SqlData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class Disposables : IDisposable
    {
        private bool _isDisposed;

        private readonly List<IDisposable> _disposables = new List<IDisposable>();

        public project0Context getContext()
        {
            string constring = File.ReadAllText("/Revature/Sql/connectionstring.txt");

            DbContextOptions<project0Context> options = new DbContextOptionsBuilder<project0Context>().UseSqlServer(constring).Options;

            var context = new project0Context(options);

            return context;

        }

        public Repository GetRepository()
        {
            var context = getContext();
            _disposables.Add(context);
            return new Repository(context);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    foreach (IDisposable disposable in _disposables)
                    {
                        disposable.Dispose();
                    }
                }

                _isDisposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
