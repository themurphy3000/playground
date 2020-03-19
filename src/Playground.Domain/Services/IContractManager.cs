﻿using System.ServiceModel;
using System.Threading.Tasks;
using Playground.Domain.Models;
using Playground.Infrastructure.Domain.Models;

namespace Playground.Domain.Services
{
    /// <summary>
    /// Contract for a service to manage Contracts.
    /// </summary>
    [ServiceContract(Name = "Playground.ContractManager")]
    public interface IContractManager
    {
        /// <summary>
        /// Creates a new contract with the provided <see cref="ContractDetailsDTO"/> contract details.
        /// </summary>
        /// <param name="contractDetails">The details for the contract to create.</param>
        /// <returns>A <see cref="ResultDTO{TSuccess, TError}"/> for the result of the creation request.
        /// If successful then it contains the unique <see cref="int"/> id for the new contract.
        /// If unsuccessful then it contains an error message describing the failure.</returns>
        Task<ResultDTO<int, string>> CreateContractAsync(ContractDetailsDTO contractDetails);

        /// <summary>
        /// Retrieves a previously saved contract with the provided unique <see cref="int"/> id.
        /// </summary>
        /// <param name="id">The unique <see cref="int"/> id for the contract to retrieve.</param>
        /// <returns>A <see cref="ResultDTO{TSuccess, TError}"/> for the result of fetch request.
        /// If successful then it contains the <see cref="ContractDTO"/> for the requested contract.
        /// If unsuccessful then it contains an error message describing the failure.</returns>
        Task<ResultDTO<ContractDTO, string>> GetContractAsync(int id);
    }
}
