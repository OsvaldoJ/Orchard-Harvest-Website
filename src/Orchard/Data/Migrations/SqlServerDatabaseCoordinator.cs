using System;
using FluentNHibernate.Cfg.Db;

namespace Orchard.Data.Migrations {
    public class SqlServerDatabaseCoordinator : DatabaseCoordinatorBase {
        private readonly string _dataFolder;
        private readonly string _connectionString;

        public SqlServerDatabaseCoordinator(string dataFolder, string connectionString) {
            _dataFolder = dataFolder;
            _connectionString = connectionString;
        }


        protected override IPersistenceConfigurer GetPersistenceConfigurer() {
            var persistence = MsSqlConfiguration.MsSql2008;
            if (string.IsNullOrEmpty(_connectionString)) {
                throw new NotImplementedException();
            }
            else {
                persistence = persistence.ConnectionString(_connectionString);
            }
            return persistence;
        }
    }
}