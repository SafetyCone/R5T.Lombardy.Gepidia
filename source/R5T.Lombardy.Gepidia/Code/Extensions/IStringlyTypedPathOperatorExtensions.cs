using System;

using R5T.Gepidia;


namespace R5T.Lombardy.Gepidia.Extensions
{
    public static class IStringlyTypedPathOperatorExtensions
    {
        /// <summary>
        /// Gets the <see cref="FileSystemEntryType"/> for a path based on whether the path is directory-indicated.
        /// Based only on whether the path is directory-indicated, determine the <see cref="FileSystemEntryType"/>.
        /// Paths do not need to actually exist, this operates at the string-level of abstraction.
        /// </summary>
        public static FileSystemEntryType GetFileSystemEntryTypeForPath(this IStringlyTypedPathOperator stringlyTypedPathOperator, string path)
        {
            var isDirectory = stringlyTypedPathOperator.IsDirectoryIndicatedPath(path);

            var entryType = FileSystemEntryTypeHelper.IsDirectoryToFileSystemEntryType(isDirectory);
            return entryType;
        }

        /// <summary>
        /// Gets the <see cref="FileSystemEntryType"/> for an actually existing path.
        /// </summary>
        /// <param name="stringlyTypedPathOperator"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static FileSystemEntryType GetFileSystemEntryTypeForExistingPath(this IStringlyTypedPathOperator stringlyTypedPathOperator, string path)
        {
            var isDirectory = stringlyTypedPathOperator.IsDirectory(path);

            var entryType = FileSystemEntryTypeHelper.IsDirectoryToFileSystemEntryType(isDirectory);
            return entryType;
        }

        /// <summary>
        /// Gets the <see cref="FileSystemEntryType"/> for a path based on whether the path is directory-indicated.
        /// Operates at the path-level of abstraction, without requiring that the path actually exist in the file-system.
        /// </summary>
        public static FileSystemEntryType GetFileSystemEntryType(this IStringlyTypedPathOperator stringlyTypedPathOperator, string path)
        {
            var output = stringlyTypedPathOperator.GetFileSystemEntryTypeForPath(path);
            return output;
        }
    }
}
