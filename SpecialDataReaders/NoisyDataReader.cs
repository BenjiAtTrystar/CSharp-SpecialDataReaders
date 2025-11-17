using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Gerk.SpecialDataReaders
{
	/// <summary>
	/// Noisy data reader that logs all method calls and property accesses. Useful for debugging.
	/// </summary>
	public class NoisyDataReader : IDataReader
	{
		private readonly Action<string> log;
		private readonly IDataReader innerReader;

		/// <summary>
		/// Creates a new instance of <see cref="NoisyDataReader"/>.
		/// </summary>
		/// <param name="innerReader">A <see cref="IDataReader"/> that is wrapped.</param>
		/// <param name="log">The log function that gets called to show each call.</param>
		public NoisyDataReader(IDataReader innerReader, Action<string> log)
		{
			this.innerReader = innerReader;
			this.log = log;
		}

		/// <inheritdoc/>
		public virtual object this[int i]
		{
			get
			{
				log($"object this[int i] - {nameof(i)}: {i}");
				var output = innerReader[i];
				log($"object this[int i] - {nameof(i)}: {i} => {output}");
				return output;
			}
		}

		/// <inheritdoc/>
		public virtual object this[string name]
		{
			get
			{
				log($"object this[string name] - {nameof(name)}: {name}");
				var output = innerReader[name];
				log($"object this[string name] - {nameof(name)}: {name} => {output}");
				return output;
			}
		}

		/// <inheritdoc/>
		public virtual int Depth
		{
			get
			{
				log($"int Depth");
				var output = innerReader.Depth;
				log($"int Depth => {output}");
				return output;
			}
		}

		/// <inheritdoc/>
		public virtual bool IsClosed
		{
			get
			{
				log($"bool IsClosed");
				var output = innerReader.IsClosed;
				log($"bool IsClosed => {output}");
				return output;
			}
		}

		/// <inheritdoc/>
		public virtual int RecordsAffected
		{
			get
			{
				log($"int RecordsAffected");
				var output = innerReader.RecordsAffected;
				log($"int RecordsAffected => {output}");
				return output;
			}
		}

		/// <inheritdoc/>
		public virtual int FieldCount
		{
			get
			{
				log($"int FieldCount");
				var output = innerReader.FieldCount;
				log($"int FieldCount => {output}");
				return output;
			}
		}

		/// <inheritdoc/>
		public virtual void Close()
		{
			log("void Close()");
			innerReader.Close();
		}

		/// <inheritdoc/>
		public virtual void Dispose()
		{
			log("void Dispose()");
			innerReader.Dispose();
		}

		/// <inheritdoc/>
		public virtual bool GetBoolean(int i)
		{
			log($"bool GetBoolean - {nameof(i)}: {i}");
			var output = innerReader.GetBoolean(i);
			log($"bool GetBoolean - {nameof(i)}: {i} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual byte GetByte(int i)
		{
			log($"byte GetByte - {nameof(i)}: {i}");
			var output = innerReader.GetByte(i);
			log($"byte GetByte - {nameof(i)}: {i} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
		{
			log($"long GetBytes - {nameof(i)}: {i}, {nameof(fieldOffset)}: {fieldOffset}, {nameof(buffer)}: {buffer}, {nameof(bufferoffset)}: {bufferoffset}, {nameof(length)}: {length}");
			var output = innerReader.GetBytes(i, fieldOffset, buffer, bufferoffset, length);
			log($"long GetBytes - {nameof(i)}: {i}, {nameof(fieldOffset)}: {fieldOffset}, {nameof(buffer)}: {buffer}, {nameof(bufferoffset)}: {bufferoffset}, {nameof(length)}: {length} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual char GetChar(int i)
		{
			log($"char GetChar - {nameof(i)}: {i}");
			var output = innerReader.GetChar(i);
			log($"char GetChar - {nameof(i)}: {i} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
		{
			log($"long GetChars - {nameof(i)}: {i}, {nameof(fieldoffset)}: {fieldoffset}, {nameof(buffer)}: {buffer}, {nameof(bufferoffset)}: {bufferoffset}, {nameof(length)}: {length}");
			var output = innerReader.GetChars(i, fieldoffset, buffer, bufferoffset, length);
			log($"long GetChars - {nameof(i)}: {i}, {nameof(fieldoffset)}: {fieldoffset}, {nameof(buffer)}: {buffer}, {nameof(bufferoffset)}: {bufferoffset}, {nameof(length)}: {length} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual IDataReader GetData(int i)
		{
			log($"IDataReader GetData - {nameof(i)}: {i}");
			var output = innerReader.GetData(i);
			log($"IDataReader GetData - {nameof(i)}: {i} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual string GetDataTypeName(int i)
		{
			log($"string GetDataTypeName - {nameof(i)}: {i}");
			var output = innerReader.GetDataTypeName(i);
			log($"string GetDataTypeName - {nameof(i)}: {i} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual DateTime GetDateTime(int i)
		{
			log($"DateTime GetDateTime - {nameof(i)}: {i}");
			var output = innerReader.GetDateTime(i);
			log($"DateTime GetDateTime - {nameof(i)}: {i} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual decimal GetDecimal(int i)
		{
			log($"decimal GetDecimal - {nameof(i)}: {i}");
			var output = innerReader.GetDecimal(i);
			log($"decimal GetDecimal - {nameof(i)}: {i} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual double GetDouble(int i)
		{
			log($"double GetDouble - {nameof(i)}: {i}");
			var output = innerReader.GetDouble(i);
			log($"double GetDouble - {nameof(i)}: {i} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual Type GetFieldType(int i)
		{
			log($"Type GetFieldType - {nameof(i)}: {i}");
			var output = innerReader.GetFieldType(i);
			log($"Type GetFieldType - {nameof(i)}: {i} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual float GetFloat(int i)
		{
			log($"float GetFloat - {nameof(i)}: {i}");
			var output = innerReader.GetFloat(i);
			log($"float GetFloat - {nameof(i)}: {i} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual Guid GetGuid(int i)
		{
			log($"Guid GetGuid - {nameof(i)}: {i}");
			var output = innerReader.GetGuid(i);
			log($"Guid GetGuid - {nameof(i)}: {i} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual short GetInt16(int i)
		{
			log($"short GetInt16 - {nameof(i)}: {i}");
			var output = innerReader.GetInt16(i);
			log($"short GetInt16 - {nameof(i)}: {i} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual int GetInt32(int i)
		{
			log($"int GetInt32 - {nameof(i)}: {i}");
			var output = innerReader.GetInt32(i);
			log($"int GetInt32 - {nameof(i)}: {i} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual long GetInt64(int i)
		{
			log($"long GetInt64 - {nameof(i)}: {i}");
			var output = innerReader.GetInt64(i);
			log($"long GetInt64 - {nameof(i)}: {i} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual string GetName(int i)
		{
			log($"string GetName - {nameof(i)}: {i}");
			var output = innerReader.GetName(i);
			log($"string GetName - {nameof(i)}: {i} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual int GetOrdinal(string name)
		{
			log($"int GetOrdinal - {nameof(name)}: {name}");
			var output = innerReader.GetOrdinal(name);
			log($"int GetOrdinal - {nameof(name)}: {name} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual DataTable GetSchemaTable()
		{
			log("DataTable GetSchemaTable()");
			var output = innerReader.GetSchemaTable();
			log($"DataTable GetSchemaTable() => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual string GetString(int i)
		{
			log($"string GetString - {nameof(i)}: {i}");
			var output = innerReader.GetString(i);
			log($"string GetString - {nameof(i)}: {i} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual object GetValue(int i)
		{
			log($"object GetValue - {nameof(i)}: {i}");
			var output = innerReader.GetValue(i);
			log($"object GetValue - {nameof(i)}: {i} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual int GetValues(object[] values)
		{
			log($"int GetValues - {nameof(values)}: {values}");
			var output = innerReader.GetValues(values);
			log($"int GetValues - {nameof(values)}: {values} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual bool IsDBNull(int i)
		{
			log($"bool IsDBNull - {nameof(i)}: {i}");
			var output = innerReader.IsDBNull(i);
			log($"bool IsDBNull - {nameof(i)}: {i} => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual bool NextResult()
		{
			log("bool NextResult()");
			var output = innerReader.NextResult();
			log($"bool NextResult() => {output}");
			return output;
		}

		/// <inheritdoc/>
		public virtual bool Read()
		{
			log("bool Read()");
			var output = innerReader.Read();
			log($"bool Read() => {output}");
			return output;
		}
	}
}
