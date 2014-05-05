using System;

namespace System
{
    
    public static partial class FuncHelper
    {
        public static Func<TReturn> GetDefaultFunc<TReturn>()
        {
            return HelperDefaultFunc<TReturn>.Instance;
        }

        public static Func<T, TReturn> GetDefaultFunc<T, TReturn>()
        {
            return HelperDefaultFunc<T, TReturn>.Instance;
        }

        public static Func<T1, T2, TReturn> GetDefaultFunc<T1, T2, TReturn>()
        {
            return HelperDefaultFunc<T1, T2, TReturn>.Instance;
        }

        public static Func<T1, T2, T3, TReturn> GetDefaultFunc<T1, T2, T3, TReturn>()
        {
            return HelperDefaultFunc<T1, T2, T3, TReturn>.Instance;
        }

        public static Func<T1, T2, T3, T4, TReturn> GetDefaultFunc<T1, T2, T3, T4, TReturn>()
        {
            return HelperDefaultFunc<T1, T2, T3, T4, TReturn>.Instance;
        }

        public static Func<bool> GetFallacyFunc()
        {
            return HelperFallacyFunc.Instance;
        }

        public static Func<T, bool> GetFallacyFunc<T>()
        {
            return HelperFallacyFunc<T>.Instance;
        }

        public static Func<T1, T2, bool> GetFallacyFunc<T1, T2>()
        {
            return HelperFallacyFunc<T1, T2>.Instance;
        }

        public static Func<T1, T2, T3, bool> GetFallacyFunc<T1, T2, T3>()
        {
            return HelperFallacyFunc<T1, T2, T3>.Instance;
        }

        public static Func<T1, T2, T3, T4, bool> GetFallacyFunc<T1, T2, T3, T4>()
        {
            return HelperFallacyFunc<T1, T2, T3, T4>.Instance;
        }


        public static Func<TReturn> GetReturnFunc<TReturn>(TReturn def)
        {
            return () =>
            {
                return def;
            };
        }

        public static Func<T, TReturn> GetReturnFunc<T, TReturn>(TReturn def)
        {
            return (T obj) =>
            {
                return def;
            };
        }

        public static Func<T1, T2, TReturn> GetReturnFunc<T1, T2, TReturn>(TReturn def)
        {
            return (T1 arg1, T2 arg2) =>
            {
                return def;
            };
        }

        public static Func<T1, T2, T3, TReturn> GetReturnFunc<T1, T2, T3, TReturn>(TReturn def)
        {
            return (T1 arg1, T2 arg2, T3 arg3) =>
            {
                return def;
            };
        }

        public static Func<T1, T2, T3, T4, TReturn> GetReturnFunc<T1, T2, T3, T4, TReturn>(TReturn def)
        {
            return (T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            {
                return def;
            };
        }

      

        public static Func<bool> GetTautologyFunc()
        {
            return HelperTautologyFunc.Instance;
        }

        public static Func<T, bool> GetTautologyFunc<T>()
        {
            return HelperTautologyFunc<T>.Instance;
        }

        public static Func<T1, T2, bool> GetTautologyFunc<T1, T2>()
        {
            return HelperTautologyFunc<T1, T2>.Instance;
        }

        public static Func<T1, T2, T3, bool> GetTautologyFunc<T1, T2, T3>()
        {
            return HelperTautologyFunc<T1, T2, T3>.Instance;
        }

        public static Func<T1, T2, T3, T4, bool> GetTautologyFunc<T1, T2, T3, T4>()
        {
            return HelperTautologyFunc<T1, T2, T3, T4>.Instance;
        }

        public static Func<TReturn> GetThrowFunc<TReturn>(Exception exception)
        {
            return () =>
            {
                throw exception;
            };
        }

        public static Func<T, TReturn> GetThrowFunc<T, TReturn>(Exception exception)
        {
            return (T obj) =>
            {
                throw exception;
            };
        }

        public static Func<T1, T2, TReturn> GetThrowFunc<T1, T2, TReturn>(Exception exception)
        {
            return (T1 arg1, T2 arg2) =>
            {
                throw exception;
            };
        }

        public static Func<T1, T2, T3, TReturn> GetThrowFunc<T1, T2, T3, TReturn>(Exception exception)
        {
            return (T1 arg1, T2 arg2, T3 arg3) =>
            {
                throw exception;
            };
        }

        public static Func<T1, T2, T3, T4, TReturn> GetThrowFunc<T1, T2, T3, T4, TReturn>(Exception exception)
        {
            return (T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            {
                throw exception;
            };
        }



        private static class HelperDefaultFunc<TReturn>
        {
            private static readonly Func<TReturn> _instance;

            static HelperDefaultFunc()
            {
                _instance = DefaultFunc;
            }

            public static Func<TReturn> Instance
            {
                get
                {
                    return _instance;
                }
            }

            private static TReturn DefaultFunc()
            {
                return default(TReturn);
            }
        }

        private static class HelperDefaultFunc<T, TReturn>
        {
            private static readonly Func<T, TReturn> _instance;

            static HelperDefaultFunc()
            {
                _instance = DefaultFunc;
            }

            public static Func<T, TReturn> Instance
            {
                get
                {
                    return _instance;
                }
            }

            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "By Design")]
            private static TReturn DefaultFunc(T obj)
            {
                return default(TReturn);
            }
        }

        private static class HelperDefaultFunc<T1, T2, TReturn>
        {
            private static readonly Func<T1, T2, TReturn> _instance;

            static HelperDefaultFunc()
            {
                _instance = DefaultFunc;
            }

            public static Func<T1, T2, TReturn> Instance
            {
                get
                {
                    return _instance;
                }
            }

            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "By Design")]
            private static TReturn DefaultFunc(T1 arg1, T2 arg2)
            {
                return default(TReturn);
            }
        }

        private static class HelperDefaultFunc<T1, T2, T3, TReturn>
        {
            private static readonly Func<T1, T2, T3, TReturn> _instance;

            static HelperDefaultFunc()
            {
                _instance = DefaultFunc;
            }

            public static Func<T1, T2, T3, TReturn> Instance
            {
                get
                {
                    return _instance;
                }
            }

            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "By Design")]
            private static TReturn DefaultFunc(T1 arg1, T2 arg2, T3 arg3)
            {
                return default(TReturn);
            }
        }

        private static class HelperDefaultFunc<T1, T2, T3, T4, TReturn>
        {
            private static readonly Func<T1, T2, T3, T4, TReturn> _instance;

            static HelperDefaultFunc()
            {
                _instance = DefaultFunc;
            }

            public static Func<T1, T2, T3, T4, TReturn> Instance
            {
                get
                {
                    return _instance;
                }
            }

            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "By Design")]
            private static TReturn DefaultFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
            {
                return default(TReturn);
            }
        }

      

        private static class HelperFallacyFunc
        {
            private static readonly Func<bool> _instance;

            static HelperFallacyFunc()
            {
                _instance = FallacyFunc;
            }

            public static Func<bool> Instance
            {
                get
                {
                    return _instance;
                }
            }

            private static bool FallacyFunc()
            {
                return false;
            }
        }

        private static class HelperFallacyFunc<T>
        {
            private static readonly Func<T, bool> _instance;

            static HelperFallacyFunc()
            {
                _instance = FallacyFunc;
            }

            public static Func<T, bool> Instance
            {
                get
                {
                    return _instance;
                }
            }

            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "By Design")]
            private static bool FallacyFunc(T obj)
            {
                return false;
            }
        }

        private static class HelperFallacyFunc<T1, T2>
        {
            private static readonly Func<T1, T2, bool> _instance;

            static HelperFallacyFunc()
            {
                _instance = FallacyFunc;
            }

            public static Func<T1, T2, bool> Instance
            {
                get
                {
                    return _instance;
                }
            }

            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "By Design")]
            private static bool FallacyFunc(T1 arg1, T2 arg2)
            {
                return false;
            }
        }

        private static class HelperFallacyFunc<T1, T2, T3>
        {
            private static readonly Func<T1, T2, T3, bool> _instance;

            static HelperFallacyFunc()
            {
                _instance = FallacyFunc;
            }

            public static Func<T1, T2, T3, bool> Instance
            {
                get
                {
                    return _instance;
                }
            }

            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "By Design")]
            private static bool FallacyFunc(T1 arg1, T2 arg2, T3 arg3)
            {
                return false;
            }
        }

        private static class HelperFallacyFunc<T1, T2, T3, T4>
        {
            private static readonly Func<T1, T2, T3, T4, bool> _instance;

            static HelperFallacyFunc()
            {
                _instance = FallacyFunc;
            }

            public static Func<T1, T2, T3, T4, bool> Instance
            {
                get
                {
                    return _instance;
                }
            }

            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "By Design")]
            private static bool FallacyFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
            {
                return false;
            }
        }

        private static class HelperTautologyFunc
        {
            private static readonly Func<bool> _instance;

            static HelperTautologyFunc()
            {
                _instance = TautologyFunc;
            }

            public static Func<bool> Instance
            {
                get
                {
                    return _instance;
                }
            }

            private static bool TautologyFunc()
            {
                return true;
            }
        }

        private static class HelperTautologyFunc<T>
        {
            private static readonly Func<T, bool> _instance;

            static HelperTautologyFunc()
            {
                _instance = TautologyFunc;
            }

            public static Func<T, bool> Instance
            {
                get
                {
                    return _instance;
                }
            }

            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "By Design")]
            private static bool TautologyFunc(T obj)
            {
                return true;
            }
        }

        private static class HelperTautologyFunc<T1, T2>
        {
            private static readonly Func<T1, T2, bool> _instance;

            static HelperTautologyFunc()
            {
                _instance = TautologyFunc;
            }

            public static Func<T1, T2, bool> Instance
            {
                get
                {
                    return _instance;
                }
            }

            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "By Design")]
            private static bool TautologyFunc(T1 arg1, T2 arg2)
            {
                return true;
            }
        }

        private static class HelperTautologyFunc<T1, T2, T3>
        {
            private static readonly Func<T1, T2, T3, bool> _instance;

            static HelperTautologyFunc()
            {
                _instance = TautologyFunc;
            }

            public static Func<T1, T2, T3, bool> Instance
            {
                get
                {
                    return _instance;
                }
            }

            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "By Design")]
            private static bool TautologyFunc(T1 arg1, T2 arg2, T3 arg3)
            {
                return true;
            }
        }

        private static class HelperTautologyFunc<T1, T2, T3, T4>
        {
            private static readonly Func<T1, T2, T3, T4, bool> _instance;

            static HelperTautologyFunc()
            {
                _instance = TautologyFunc;
            }

            public static Func<T1, T2, T3, T4, bool> Instance
            {
                get
                {
                    return _instance;
                }
            }

            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "By Design")]
            private static bool TautologyFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
            {
                return true;
            }
        }

    }
}