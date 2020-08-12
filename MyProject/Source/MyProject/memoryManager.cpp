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
		sizeof(float) * 4);

	if (!SharedMemoryData){
		UE_LOG(LogClass, Log, TEXT("Memory-mapped data does not exist."));
		return NULL;
	}

	return SharedMemoryData;
}

void UmemoryManager::CloseSharedMemory() {
	if (SharedMemoryData != nullptr){
		UnmapViewOfFile(SharedMemoryData);
		SharedMemoryData = nullptr;
	}

	if (SharedMemoryHandle != nullptr){
		CloseHandle(SharedMemoryHandle);
		SharedMemoryHandle = nullptr;
	}
}