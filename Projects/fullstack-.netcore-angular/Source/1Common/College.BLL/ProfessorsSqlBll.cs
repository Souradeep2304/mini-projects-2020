﻿using College.Core.Entities;
using College.Core.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace College.BLL
{

    public class ProfessorsSqlBll : IProfessorsSqlBll
    {
        private readonly IProfessorsSqlDal _professorsSqlDal;
        private readonly ILogger<ProfessorsSqlBll> _logger;

        public ProfessorsSqlBll(IProfessorsSqlDal professorsSqlDal, ILogger<ProfessorsSqlBll> logger)
        {
            _professorsSqlDal = professorsSqlDal ?? throw new ArgumentNullException(nameof(professorsSqlDal));
            
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Professor> AddProfessor(Professor professor)
        {
            _logger.Log(LogLevel.Debug, "Request Received for ProfessorsSqlBll::AddProfessor");

            var newProfessor = await _professorsSqlDal.AddProfessor(professor);

            _logger.Log(LogLevel.Debug, "Returning the results from ProfessorsSqlBll::AddProfessor");

            return newProfessor;
        }

        public async Task<IEnumerable<Professor>> GetAllProfessors()
        {
            _logger.Log(LogLevel.Debug, "Request Received for ProfessorsSqlBll::GetAllProfessors");

            var allProfessors = await _professorsSqlDal.GetAllProfessors();

            _logger.Log(LogLevel.Debug, "Returning the results from ProfessorsSqlBll::GetAllProfessors");

            return allProfessors;
        }

        public async Task<Professor> GetProfessorById(Guid professorId)
        {
            _logger.Log(LogLevel.Debug, "Request Received for ProfessorsSqlBll::GetProfessorById");

            var professor = await _professorsSqlDal.GetProfessorById(professorId);

            _logger.Log(LogLevel.Debug, "Returning the results from ProfessorsSqlBll::GetProfessorById");

            return professor;
        }

        public async Task<Professor> UpdateProfessor(Professor professor)
        {
            _logger.Log(LogLevel.Debug, "Request Received for ProfessorsSqlBll::UpdateProfessor");

            var updatedProfessor = await _professorsSqlDal.UpdateProfessor(professor);

            _logger.Log(LogLevel.Debug, "Returning the results from ProfessorsSqlBll::UpdateProfessor");

            return updatedProfessor;
        }

        public async Task<bool> DeleteProfessorById(Guid professorId)
        {
            _logger.Log(LogLevel.Debug, "Request Received for ProfessorsSqlBll::DeleteProfessorById");

            var professorDeleted = await _professorsSqlDal.DeleteProfessorById(professorId);

            _logger.Log(LogLevel.Debug, "Returning the results from ProfessorsSqlBll::DeleteProfessorById");

            return professorDeleted;
        }

    }

}
