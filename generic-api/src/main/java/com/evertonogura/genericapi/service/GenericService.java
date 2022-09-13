package com.evertonogura.genericapi.service;

import java.util.List;

import com.evertonogura.genericapi.model.GenericModel;

public interface GenericService {
	
	GenericModel newGeneric(GenericModel newGeneric);
	
	GenericModel updateGeneric(Long id, GenericModel newGeneric);
	
	List<GenericModel> listGeneric();
	
	GenericModel getGeneric(Long id);
	
	void deleteGeneric(Long id);
	
}
