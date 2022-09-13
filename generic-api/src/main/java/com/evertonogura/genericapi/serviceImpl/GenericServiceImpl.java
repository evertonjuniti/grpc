package com.evertonogura.genericapi.serviceImpl;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.evertonogura.genericapi.entity.GenericChildEntity;
import com.evertonogura.genericapi.entity.GenericEntity;
import com.evertonogura.genericapi.model.GenericChildModel;
import com.evertonogura.genericapi.model.GenericModel;
import com.evertonogura.genericapi.repository.GenericRepository;
import com.evertonogura.genericapi.service.GenericService;

@Service
public class GenericServiceImpl implements GenericService {
	
	@Autowired
	private GenericRepository repository;
	
	@Override
	public GenericModel newGeneric(GenericModel newGeneric) {
		return toModel(repository.save(toEntity(newGeneric)));
	}

	@Override
	public GenericModel updateGeneric(Long id, GenericModel newGeneric) {
		Optional<GenericEntity> result = repository.findById(id);
		
		if (result.isPresent()) {
			result.get().setName(newGeneric.getName());
			result.get().setActive(newGeneric.getActive());
			result.get().setDate(newGeneric.getDate());

			return toModel(repository.save(result.get()));
		}
		else
			return null;
	}

	@Override
	public List<GenericModel> listGeneric() {
		List<GenericModel> lista = new ArrayList<GenericModel>();
		List<GenericEntity> result = repository.findAll();
		
		for (GenericEntity entity : result) {
			lista.add(toModel(entity));
		}
		
		return lista;
	}

	@Override
	public GenericModel getGeneric(Long id) {
		Optional<GenericEntity> result = repository.findById(id);
		
		if (result.isPresent())
			return toModel(result.get());
		else
			return toModel(null);
	}

	@Override
	public void deleteGeneric(Long id) {
		Optional<GenericEntity> result = repository.findById(id);
		
		if (result.isPresent())
			repository.delete(result.get());
	}
	
	private GenericEntity toEntity(GenericModel model) {
		GenericEntity entity = new GenericEntity();
		entity.setName(model.getName());
		entity.setActive(model.getActive());
		entity.setDate(model.getDate());
		entity.setItems(null);
		
		return entity;
	}
	
	private GenericModel toModel(GenericEntity entity) {
		List<GenericChildModel> items = new ArrayList<GenericChildModel>();
		
		if (entity.getItems() != null && entity.getItems().isEmpty()) {
			for (GenericChildEntity entityItem : entity.getItems()) {
				GenericChildModel item = new GenericChildModel(
						entityItem.getId(),
						entityItem.getDescription(),
						entityItem.getValue());
				items.add(item);
			}
		}
		
		GenericModel model = new GenericModel(
				entity.getId(), 
				entity.getName(), 
				entity.getActive(), 
				entity.getDate(), 
				items);
		
		return model;
	}
	
}
