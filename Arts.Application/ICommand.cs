﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Arts.Application
{
    public interface ICommand<TRequest> : IUseCase
    {
        void Execute(TRequest request);
    }

    public interface IQuery<TSearch, TResult>: IUseCase
    {
        TResult Execute(TSearch search);
    }

    public interface IUseCase
    {
        public int Id { get;}
        public string Name { get;}
    }
}
