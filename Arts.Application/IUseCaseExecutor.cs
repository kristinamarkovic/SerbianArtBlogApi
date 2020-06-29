﻿using Arts.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arts.Application
{
    public class IUseCaseExecutor
    {
        private readonly IApplicationActor actor;
        private readonly IUseCaseLogger logger;

        public IUseCaseExecutor(IApplicationActor actor, IUseCaseLogger logger)
        {
            this.actor = actor;
            this.logger = logger;
        }

        //imamo dve komande
        public void ExecuteCommand<TRequest>(ICommand<TRequest> command, TRequest request)
        {
            logger.Log(command, actor, request);
            if(!actor.AllowedUseCases.Contains(command.Id))
            {
                throw new UnAuthorizedUseCaseException(command, actor);
            }

            command.Execute(request);
        }

        public TResult ExecuteQuery<TSearch, TResult>(IQuery<TSearch,TResult> query, TSearch search)
        {
            logger.Log(query, actor, search);

            if(!actor.AllowedUseCases.Contains(query.Id))
            {
                throw new UnAuthorizedUseCaseException(query, actor);
            }

            return query.Execute(search);
        }


    }
}
