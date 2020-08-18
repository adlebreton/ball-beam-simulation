// Fill out your copyright notice in the Description page of Project Settings.


#include "memoryManager.h"
//#include "Windows/MinWindows.h" //crashes UE and corrupts project
#define WIN32_LEAN_AND_MEAN
// above fixes issue below
#include "windows.h" //will not compile "macro redefinition"


#define BUF_SIZE 256
// Sets default values for this component's properties
UmemoryManager::UmemoryManager(){

}

UmemoryManager::~UmemoryManager(){
	this->CloseSharedMemory();
}

bool UmemoryManager::OpenMappedMemory() {
	SharedMemoryHandle = CreateFileMapping(
		INVALID_HANDLE_VALUE,    // use paging file
		NULL,                    // default security
		PAGE_READWRITE,          // read/write access
		0,                       // maximum object size (high-order DWORD)
		BUF_SIZE,                // maximum object size (low-order DWORD)
		TEXT("BallBeamSharedMemory"));                 // name of mapping object

	if (!SharedMemoryHandle){
		UE_LOG(LogClass, Log, TEXT("Memory-mapped file could not be created."));
		return false;
	}else
		UE_LOG(LogTemp, Warning, TEXT("Memory-mapped file success."));
	return true;
}

float* UmemoryManager::GetMappedMemoryData() {
	SharedMemoryData = (float*)MapViewOfFile(SharedMemoryHandle,
		FILE_MAP_ALL_ACCESS,
		0, 0,
		sizeof(float) * 4); // from cpp to c#: delta, ball pos and angle //from c# to cpp: target angle

	if (!SharedMemoryData){
		UE_LOG(LogClass, Log, TEXT("Memory-mapped data does not exist."));
		return NULL;
	}
	return SharedMemoryData;
	/*_delta= (float*)MapViewOfFile(SharedMemoryHandle,
		FILE_MAP_ALL_ACCESS,
		0, 0,
		sizeof(float));
	_currPos = (float*)MapViewOfFile(SharedMemoryHandle,
		FILE_MAP_ALL_ACCESS,
		0, sizeof(float),
		sizeof(float));
	_currAngle = (float*)MapViewOfFile(SharedMemoryHandle,
		FILE_MAP_ALL_ACCESS,
		0, sizeof(float)*2,
		sizeof(float));
	_targAngle = (float*)MapViewOfFile(SharedMemoryHandle,
		FILE_MAP_ALL_ACCESS,
		0, sizeof(float) * 3,
		sizeof(float));
	if (!_delta || !_currPos || !_currAngle || !_targAngle) {
		UE_LOG(LogClass, Log, TEXT("Memory-mapped data does not exist."));
	}*/
}

void UmemoryManager::CloseSharedMemory() {
	if (SharedMemoryData != nullptr){
		UnmapViewOfFile(SharedMemoryData);
		SharedMemoryData = nullptr;
	}
	/*if (_delta != nullptr || _currPos != nullptr || _currAngle != nullptr || _targAngle != nullptr) {
		UnmapViewOfFile(_delta);
		_delta = nullptr;
		UnmapViewOfFile(_currPos);
		_currPos = nullptr;
		UnmapViewOfFile(_currAngle);
		_currAngle = nullptr;
		UnmapViewOfFile(_targAngle);
		_targAngle = nullptr;
	}*/

	if (SharedMemoryHandle != nullptr){
		CloseHandle(SharedMemoryHandle);
		SharedMemoryHandle = nullptr;
	}
}

void UmemoryManager::setDelta(float delta) {
	SharedMemoryData[0] = delta;
	//_delta[0] = delta;
}

void UmemoryManager::setCurrPos(float pos) {
	SharedMemoryData[1] = pos;
	//_currPos[0] = pos;
}

void UmemoryManager::setCurrAngle(float angle) {
	SharedMemoryData[2] = angle;
	//_currAngle[0] = angle;
}

float UmemoryManager::getTargetAngle() {
	return SharedMemoryData[3];
	//return _targAngle[0];
}