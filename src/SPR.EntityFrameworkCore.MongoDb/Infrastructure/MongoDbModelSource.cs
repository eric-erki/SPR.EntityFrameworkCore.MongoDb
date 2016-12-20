﻿using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using Microsoft.EntityFrameworkCore.Utilities;

namespace SPR.EntityFrameworkCore.MongoDb.Infrastructure
{
    public class MongoDbModelSource : ModelSource
    {
        public MongoDbModelSource(
            [NotNull] IDbSetFinder setFinder,
            [NotNull] ICoreConventionSetBuilder coreConventionSetBuilder,
            [NotNull] IModelCustomizer modelCustomizer,
            [NotNull] IModelCacheKeyFactory modelCacheKeyFactory)
            : base(
                    Check.NotNull(setFinder, nameof(setFinder)),
                    Check.NotNull(coreConventionSetBuilder,
                                  nameof(coreConventionSetBuilder)),
                    Check.NotNull(modelCustomizer,
                                  nameof(modelCustomizer)),
                    Check.NotNull(modelCacheKeyFactory,
                                  nameof(modelCacheKeyFactory)))
        {
        }
    }
}
