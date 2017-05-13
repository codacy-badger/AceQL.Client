﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceQL.Client.Api
{
    /// <summary>
    /// Class that allows to store the progress between 0 and 100 for a Blob/Clob upload or download.
    /// </summary>
    public class ProgressHolder
    {
        private int progress = 0;

        /// <summary>
        /// The progress value between 0 and 100.
        /// </summary>
        public int Value
        {
            get
            {
                return progress;
            }

            set
            {
                progress = value;
            }
        }

        /// <summary>
        /// Returns the string representation of progress.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return progress.ToString();
        }
    }
}