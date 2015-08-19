using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CohesionAndCoupling
{
    static class FileUtils
    {
        internal static string GetFileExtension(string fileName)
        {
            Validator.ValidateIfNullOrEmpty(fileName, "The input string cannot be empty.");

            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        internal static string GetFileNameWithoutExtension(string fileName)
        {
            Validator.ValidateIfNullOrEmpty(fileName, "The input string cannot be empty.");

            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string nameWithoutExtension = fileName.Substring(0, indexOfLastDot);
            return nameWithoutExtension;
        }

    }
}
