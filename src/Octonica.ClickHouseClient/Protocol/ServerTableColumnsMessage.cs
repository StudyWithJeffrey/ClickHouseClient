﻿#region License Apache 2.0
/* Copyright 2019-2020 Octonica
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
#endregion

using System.Threading;
using System.Threading.Tasks;

namespace Octonica.ClickHouseClient.Protocol
{
    internal sealed class ServerTableColumnsMessage : IServerMessage
    {
        public ServerMessageCode MessageCode => ServerMessageCode.TableColumns;

        public string Columns { get; }

        private ServerTableColumnsMessage(string columns)
        {
            Columns = columns;
        }

        public static async ValueTask<ServerTableColumnsMessage> Read(ClickHouseBinaryProtocolReader reader, bool async, CancellationToken cancellationToken)
        {
            await reader.ReadString(async, cancellationToken);
            var columns = await reader.ReadString(async, cancellationToken);

            return new ServerTableColumnsMessage(columns);
        }
    }
}
