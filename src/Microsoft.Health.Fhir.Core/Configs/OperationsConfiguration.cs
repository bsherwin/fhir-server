﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using Microsoft.Health.Fhir.Core.Features.Operations;

namespace Microsoft.Health.Fhir.Core.Configs
{
    public class OperationsConfiguration
    {
        public ExportJobConfiguration Export { get; set; } = new ExportJobConfiguration();

        public ReindexJobConfiguration Reindex { get; set; } = new ReindexJobConfiguration();

        public ConvertDataConfiguration ConvertData { get; set; } = new ConvertDataConfiguration();

        public ValidateOperationConfiguration Validate { get; set; } = new ValidateOperationConfiguration();

        public IntegrationDataStoreConfiguration IntegrationDataStore { get; set; } = new IntegrationDataStoreConfiguration();

        public ImportJobConfiguration Import { get; set; } = new ImportJobConfiguration();

        public BulkDeleteJobConfiguration BulkDelete { get; set; } = new BulkDeleteJobConfiguration();
    }
}
