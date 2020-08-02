﻿using System;
using System.Threading;
using System.Threading.Tasks;
using TestEnvironment.Docker.DockerApi.Abstractions.Models;

namespace TestEnvironment.Docker.DockerApi.Abstractions.Services
{
    public interface IDockerImagesService
    {
        public Task BuildImage(ImageFromDockerfileConfiguration configuration, string tempFileName, CancellationToken cancellationToken = default);

        public Task<bool> IsExists(string imageName, string tag, CancellationToken cancellationToken = default);

        public Task PullImage(string imageName, string tag, Action<string, string, string> progressAction = null, CancellationToken cancellationToken = default);
    }
}
