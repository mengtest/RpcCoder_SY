// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ServerModelRpc.proto

#ifndef PROTOBUF_ServerModelRpc_2eproto__INCLUDED
#define PROTOBUF_ServerModelRpc_2eproto__INCLUDED

#include <string>

#include <google/protobuf/stubs/common.h>

#if GOOGLE_PROTOBUF_VERSION < 2005000
#error This file was generated by a newer version of protoc which is
#error incompatible with your Protocol Buffer headers.  Please update
#error your headers.
#endif
#if 2005000 < GOOGLE_PROTOBUF_MIN_PROTOC_VERSION
#error This file was generated by an older version of protoc which is
#error incompatible with your Protocol Buffer headers.  Please
#error regenerate this file with a newer version of protoc.
#endif

#include <google/protobuf/generated_message_util.h>
#include <google/protobuf/message.h>
#include <google/protobuf/repeated_field.h>
#include <google/protobuf/extension_set.h>
#include <google/protobuf/unknown_field_set.h>
#include "PublicStruct.pb.h"
// @@protoc_insertion_point(includes)

// Internal implementation detail -- do not call these.
void  protobuf_AddDesc_ServerModelRpc_2eproto();
void protobuf_AssignDesc_ServerModelRpc_2eproto();
void protobuf_ShutdownFile_ServerModelRpc_2eproto();

class ServerModelRpcLoginAsk;
class ServerModelRpcLoginReply;

// ===================================================================

class ServerModelRpcLoginAsk : public ::google::protobuf::Message {
 public:
  ServerModelRpcLoginAsk();
  virtual ~ServerModelRpcLoginAsk();

  ServerModelRpcLoginAsk(const ServerModelRpcLoginAsk& from);

  inline ServerModelRpcLoginAsk& operator=(const ServerModelRpcLoginAsk& from) {
    CopyFrom(from);
    return *this;
  }

  inline const ::google::protobuf::UnknownFieldSet& unknown_fields() const {
    return _unknown_fields_;
  }

  inline ::google::protobuf::UnknownFieldSet* mutable_unknown_fields() {
    return &_unknown_fields_;
  }

  static const ::google::protobuf::Descriptor* descriptor();
  static const ServerModelRpcLoginAsk& default_instance();

  void Swap(ServerModelRpcLoginAsk* other);

  // implements Message ----------------------------------------------

  ServerModelRpcLoginAsk* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const ServerModelRpcLoginAsk& from);
  void MergeFrom(const ServerModelRpcLoginAsk& from);
  void Clear();
  bool IsInitialized() const;

  int ByteSize() const;
  bool MergePartialFromCodedStream(
      ::google::protobuf::io::CodedInputStream* input);
  void SerializeWithCachedSizes(
      ::google::protobuf::io::CodedOutputStream* output) const;
  ::google::protobuf::uint8* SerializeWithCachedSizesToArray(::google::protobuf::uint8* output) const;
  int GetCachedSize() const { return _cached_size_; }
  private:
  void SharedCtor();
  void SharedDtor();
  void SetCachedSize(int size) const;
  public:

  ::google::protobuf::Metadata GetMetadata() const;

  // nested types ----------------------------------------------------

  // accessors -------------------------------------------------------

  // optional sint32 Result = 1 [default = -1];
  inline bool has_result() const;
  inline void clear_result();
  static const int kResultFieldNumber = 1;
  inline ::google::protobuf::int32 result() const;
  inline void set_result(::google::protobuf::int32 value);

  // optional sint32 Type = 2 [default = -1];
  inline bool has_type() const;
  inline void clear_type();
  static const int kTypeFieldNumber = 2;
  inline ::google::protobuf::int32 type() const;
  inline void set_type(::google::protobuf::int32 value);

  // optional string TestString = 3;
  inline bool has_teststring() const;
  inline void clear_teststring();
  static const int kTestStringFieldNumber = 3;
  inline const ::std::string& teststring() const;
  inline void set_teststring(const ::std::string& value);
  inline void set_teststring(const char* value);
  inline void set_teststring(const char* value, size_t size);
  inline ::std::string* mutable_teststring();
  inline ::std::string* release_teststring();
  inline void set_allocated_teststring(::std::string* teststring);

  // @@protoc_insertion_point(class_scope:ServerModelRpcLoginAsk)
 private:
  inline void set_has_result();
  inline void clear_has_result();
  inline void set_has_type();
  inline void clear_has_type();
  inline void set_has_teststring();
  inline void clear_has_teststring();

  ::google::protobuf::UnknownFieldSet _unknown_fields_;

  ::google::protobuf::int32 result_;
  ::google::protobuf::int32 type_;
  ::std::string* teststring_;

  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[(3 + 31) / 32];

  friend void  protobuf_AddDesc_ServerModelRpc_2eproto();
  friend void protobuf_AssignDesc_ServerModelRpc_2eproto();
  friend void protobuf_ShutdownFile_ServerModelRpc_2eproto();

  void InitAsDefaultInstance();
  static ServerModelRpcLoginAsk* default_instance_;
};
// -------------------------------------------------------------------

class ServerModelRpcLoginReply : public ::google::protobuf::Message {
 public:
  ServerModelRpcLoginReply();
  virtual ~ServerModelRpcLoginReply();

  ServerModelRpcLoginReply(const ServerModelRpcLoginReply& from);

  inline ServerModelRpcLoginReply& operator=(const ServerModelRpcLoginReply& from) {
    CopyFrom(from);
    return *this;
  }

  inline const ::google::protobuf::UnknownFieldSet& unknown_fields() const {
    return _unknown_fields_;
  }

  inline ::google::protobuf::UnknownFieldSet* mutable_unknown_fields() {
    return &_unknown_fields_;
  }

  static const ::google::protobuf::Descriptor* descriptor();
  static const ServerModelRpcLoginReply& default_instance();

  void Swap(ServerModelRpcLoginReply* other);

  // implements Message ----------------------------------------------

  ServerModelRpcLoginReply* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const ServerModelRpcLoginReply& from);
  void MergeFrom(const ServerModelRpcLoginReply& from);
  void Clear();
  bool IsInitialized() const;

  int ByteSize() const;
  bool MergePartialFromCodedStream(
      ::google::protobuf::io::CodedInputStream* input);
  void SerializeWithCachedSizes(
      ::google::protobuf::io::CodedOutputStream* output) const;
  ::google::protobuf::uint8* SerializeWithCachedSizesToArray(::google::protobuf::uint8* output) const;
  int GetCachedSize() const { return _cached_size_; }
  private:
  void SharedCtor();
  void SharedDtor();
  void SetCachedSize(int size) const;
  public:

  ::google::protobuf::Metadata GetMetadata() const;

  // nested types ----------------------------------------------------

  // accessors -------------------------------------------------------

  // optional sint32 Result = 1 [default = -9999];
  inline bool has_result() const;
  inline void clear_result();
  static const int kResultFieldNumber = 1;
  inline ::google::protobuf::int32 result() const;
  inline void set_result(::google::protobuf::int32 value);

  // @@protoc_insertion_point(class_scope:ServerModelRpcLoginReply)
 private:
  inline void set_has_result();
  inline void clear_has_result();

  ::google::protobuf::UnknownFieldSet _unknown_fields_;

  ::google::protobuf::int32 result_;

  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[(1 + 31) / 32];

  friend void  protobuf_AddDesc_ServerModelRpc_2eproto();
  friend void protobuf_AssignDesc_ServerModelRpc_2eproto();
  friend void protobuf_ShutdownFile_ServerModelRpc_2eproto();

  void InitAsDefaultInstance();
  static ServerModelRpcLoginReply* default_instance_;
};
// ===================================================================


// ===================================================================

// ServerModelRpcLoginAsk

// optional sint32 Result = 1 [default = -1];
inline bool ServerModelRpcLoginAsk::has_result() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void ServerModelRpcLoginAsk::set_has_result() {
  _has_bits_[0] |= 0x00000001u;
}
inline void ServerModelRpcLoginAsk::clear_has_result() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void ServerModelRpcLoginAsk::clear_result() {
  result_ = -1;
  clear_has_result();
}
inline ::google::protobuf::int32 ServerModelRpcLoginAsk::result() const {
  return result_;
}
inline void ServerModelRpcLoginAsk::set_result(::google::protobuf::int32 value) {
  set_has_result();
  result_ = value;
}

// optional sint32 Type = 2 [default = -1];
inline bool ServerModelRpcLoginAsk::has_type() const {
  return (_has_bits_[0] & 0x00000002u) != 0;
}
inline void ServerModelRpcLoginAsk::set_has_type() {
  _has_bits_[0] |= 0x00000002u;
}
inline void ServerModelRpcLoginAsk::clear_has_type() {
  _has_bits_[0] &= ~0x00000002u;
}
inline void ServerModelRpcLoginAsk::clear_type() {
  type_ = -1;
  clear_has_type();
}
inline ::google::protobuf::int32 ServerModelRpcLoginAsk::type() const {
  return type_;
}
inline void ServerModelRpcLoginAsk::set_type(::google::protobuf::int32 value) {
  set_has_type();
  type_ = value;
}

// optional string TestString = 3;
inline bool ServerModelRpcLoginAsk::has_teststring() const {
  return (_has_bits_[0] & 0x00000004u) != 0;
}
inline void ServerModelRpcLoginAsk::set_has_teststring() {
  _has_bits_[0] |= 0x00000004u;
}
inline void ServerModelRpcLoginAsk::clear_has_teststring() {
  _has_bits_[0] &= ~0x00000004u;
}
inline void ServerModelRpcLoginAsk::clear_teststring() {
  if (teststring_ != &::google::protobuf::internal::kEmptyString) {
    teststring_->clear();
  }
  clear_has_teststring();
}
inline const ::std::string& ServerModelRpcLoginAsk::teststring() const {
  return *teststring_;
}
inline void ServerModelRpcLoginAsk::set_teststring(const ::std::string& value) {
  set_has_teststring();
  if (teststring_ == &::google::protobuf::internal::kEmptyString) {
    teststring_ = new ::std::string;
  }
  teststring_->assign(value);
}
inline void ServerModelRpcLoginAsk::set_teststring(const char* value) {
  set_has_teststring();
  if (teststring_ == &::google::protobuf::internal::kEmptyString) {
    teststring_ = new ::std::string;
  }
  teststring_->assign(value);
}
inline void ServerModelRpcLoginAsk::set_teststring(const char* value, size_t size) {
  set_has_teststring();
  if (teststring_ == &::google::protobuf::internal::kEmptyString) {
    teststring_ = new ::std::string;
  }
  teststring_->assign(reinterpret_cast<const char*>(value), size);
}
inline ::std::string* ServerModelRpcLoginAsk::mutable_teststring() {
  set_has_teststring();
  if (teststring_ == &::google::protobuf::internal::kEmptyString) {
    teststring_ = new ::std::string;
  }
  return teststring_;
}
inline ::std::string* ServerModelRpcLoginAsk::release_teststring() {
  clear_has_teststring();
  if (teststring_ == &::google::protobuf::internal::kEmptyString) {
    return NULL;
  } else {
    ::std::string* temp = teststring_;
    teststring_ = const_cast< ::std::string*>(&::google::protobuf::internal::kEmptyString);
    return temp;
  }
}
inline void ServerModelRpcLoginAsk::set_allocated_teststring(::std::string* teststring) {
  if (teststring_ != &::google::protobuf::internal::kEmptyString) {
    delete teststring_;
  }
  if (teststring) {
    set_has_teststring();
    teststring_ = teststring;
  } else {
    clear_has_teststring();
    teststring_ = const_cast< ::std::string*>(&::google::protobuf::internal::kEmptyString);
  }
}

// -------------------------------------------------------------------

// ServerModelRpcLoginReply

// optional sint32 Result = 1 [default = -9999];
inline bool ServerModelRpcLoginReply::has_result() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void ServerModelRpcLoginReply::set_has_result() {
  _has_bits_[0] |= 0x00000001u;
}
inline void ServerModelRpcLoginReply::clear_has_result() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void ServerModelRpcLoginReply::clear_result() {
  result_ = -9999;
  clear_has_result();
}
inline ::google::protobuf::int32 ServerModelRpcLoginReply::result() const {
  return result_;
}
inline void ServerModelRpcLoginReply::set_result(::google::protobuf::int32 value) {
  set_has_result();
  result_ = value;
}


// @@protoc_insertion_point(namespace_scope)

#ifndef SWIG
namespace google {
namespace protobuf {


}  // namespace google
}  // namespace protobuf
#endif  // SWIG

// @@protoc_insertion_point(global_scope)

#endif  // PROTOBUF_ServerModelRpc_2eproto__INCLUDED