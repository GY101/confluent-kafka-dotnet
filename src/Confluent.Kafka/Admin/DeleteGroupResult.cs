// Copyright 2018 Confluent Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Refer to LICENSE for more information.

using System.Runtime.InteropServices;

namespace Confluent.Kafka.Admin
{
    unsafe struct DeleteGroupResult
    {
        /// <summary>
        /// 组名
        /// </summary>
        public string Group;
        /// <summary>
        /// Error object, or NULL on success
        /// </summary>
        public Errors* Error;

        //用不到直接忽略
        /** Partitions, used by DeleteConsumerGroupOffsets. */
        // rd_kafka_topic_partition_list_t* partitions;
        // char data[1]; /**< Group name */
    }
    unsafe struct Errors
    {
        //rd_kafka_resp_err_t code; /**< Error code. */
        /// <summary>
        /// Error code
        /// 枚举类型
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public ErrorCode Code;

        /// <summary>
        /// Human readable error string, allocated
        /// with the rd_kafka_error_s struct
        /// after the struct.
        /// Possibly NULL.
        /// </summary>
        public char* ErrStr;

        //用不到直接忽略
        //rd_bool_t fatal;          /**< This error is a fatal error. */
        //rd_bool_t retriable;      /**< Operation is retriable. */
        //rd_bool_t
        //txn_requires_abort; /**< This is an abortable transaction error.*/
    }

}
