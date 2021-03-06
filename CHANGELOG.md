### Octonica.ClickHouseClient release v1.0.17, 2020-12-10

#### Bug Fix

* Fixed execution of queries which affect large (greater than 2^31) number of rows ([#15](https://github.com/Octonica/ClickHouseClient/issues/15)).
* Fixed comparison of parameter's names in ClickHouseParameterCollection.

#### Improvement

* Added public method `ClickHouseParameter.IsValidParameterName` which allows to check if the string can be used as the name of a parameter.

### Octonica.ClickHouseClient release v1.0.14, 2020-12-02

#### Bug Fix

* The driver was incompatible with ClickHouse v2.10 and higher.
* Fixed writing columns from a source which contains more rows than `rowCount`.
* Fixed writing columns from a source which implements `IList<T>` but doesn't implement `IReadOnlyList<T>`.

### Octonica.ClickHouseClient release v1.0.13, 2020-11-11

#### Backward Incompatible Change

* The default name of the client changed from `Octonica.ClickHouse` to `Octonica.ClickHouseClient`.

#### New Feature

* Added type `DateTime64`.
* Implemented methods `NextResult` and `NextResultAsync` in `ClickHouseDataReader`. These methods can be used to read totals and extremes ([#11](https://github.com/Octonica/ClickHouseClient/issues/11)).
* Added `Extremes` property to `ClickHouseCommand`. It allows to toggle `extremes` setting for the query.
* Added `TimeZone` property to `ClickHouseParameter`. It allows to specify the timezone for datetime types.
* Array can be used as the value of command parameter. Added properties `IsArray` and `ArrayRank` to `ClickHouseParameter` ([#14](https://github.com/Octonica/ClickHouseClient/issues/14)).

#### Bug Fix

* The type `UInt64` was mapped to the type `UInt32` in the command parameter.

#### Improvement

* Detection of attempts to connect to ClickHouse server with HTTP protocol ([#10](https://github.com/Octonica/ClickHouseClient/issues/10)).
* `ReadWriteTimeout` is respected in async network operations if `cancellationToken` is not defined (i.e. `CanellationToken.None`).

#### Miscellaneous

* Default protocol revision is set to 54441.
