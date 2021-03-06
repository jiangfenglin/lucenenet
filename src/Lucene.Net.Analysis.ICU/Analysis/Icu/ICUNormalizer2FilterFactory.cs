﻿// LUCENENET TODO: Port issues - missing Normalizer2 dependency from icu.net

//using Icu;
//using Lucene.Net.Analysis.Util;
//using Lucene.Net.Support;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Lucene.Net.Analysis.ICU
//{
//    /*
//     * Licensed to the Apache Software Foundation (ASF) under one or more
//     * contributor license agreements.  See the NOTICE file distributed with
//     * this work for additional information regarding copyright ownership.
//     * The ASF licenses this file to You under the Apache License, Version 2.0
//     * (the "License"); you may not use this file except in compliance with
//     * the License.  You may obtain a copy of the License at
//     *
//     *     http://www.apache.org/licenses/LICENSE-2.0
//     *
//     * Unless required by applicable law or agreed to in writing, software
//     * distributed under the License is distributed on an "AS IS" BASIS,
//     * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//     * See the License for the specific language governing permissions and
//     * limitations under the License.
//     */

//    public class ICUNormalizer2FilterFactory : TokenFilterFactory, IMultiTermAwareComponent
//    {
//        private readonly Normalizer2 normalizer;

//        /// <summary>Creates a new ICUNormalizer2FilterFactory</summary>
//        public ICUNormalizer2FilterFactory(IDictionary<string, string> args)
//            : base(args)
//        {
//            string name = Get(args, "name", "NFKC");
//            //string name = Get(args, "name", "nfkc_cf");
//            //string mode = Get(args, "mode", new string[] { "compose", "decompose" }, "compose");

//            var mode = (Normalizer.UNormalizationMode)Enum.Parse(typeof(Normalizer.UNormalizationMode), "UNORM_" + name);
//            Normalizer2 normalizer = new Normalizer2(mode);

//            //Normalizer2 normalizer = Normalizer2.getInstance
//            //    (null, name, "compose".Equals(mode) ? Normalizer2.Mode.COMPOSE : Normalizer2.Mode.DECOMPOSE);

//            string filter = Get(args, "filter");
//            if (filter != null)
//            {
//                //UnicodeSet set = new UnicodeSet(filter);
//                var set = UnicodeSet.ToCharacters(filter);
//                if (set.Any())
//                {
//                    //set.freeze();
//                    normalizer = new FilteredNormalizer2(normalizer, set);
//                }
//            }
//            if (args.Count != 0)
//            {
//                throw new ArgumentException("Unknown parameters: " + args);
//            }
//            this.normalizer = normalizer;
//        }

//        // TODO: support custom normalization
//        public override TokenStream Create(TokenStream input)
//        {
//            return new ICUNormalizer2Filter(input, normalizer);
//        }

//        public virtual AbstractAnalysisFactory GetMultiTermComponent()
//        {
//            return this;
//        }
//    }
//}
